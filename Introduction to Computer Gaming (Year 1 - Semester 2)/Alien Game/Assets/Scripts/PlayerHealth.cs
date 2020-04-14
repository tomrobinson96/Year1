using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Handle hitpoints and damages
/// </summary>
public class PlayerHealth : MonoBehaviour
{
	/// <summary>
	/// Total hitpoints
	/// </summary>
	public int hp = 100;
	
	/// <summary>
	/// Enemy or player?
	/// </summary>
	public bool isEnemy = true;

	public Slider healthSlider;
	public Image damageImage;
	public float flashSpeed = 5f;
	public Color flashColour = new Color (1f, 0f, 0f, 0.5f);
	public AudioClip[] audioClip;

	Animator anim;
	bool damaged;

	void Awake()
	{
				anim = GetComponent<Animator> ();
	}

	void Update()
	{
		if(damaged)
		{
			PlaySound(0);
			// ... set the colour of the damageImage to the flash colour.
			damageImage.color = flashColour;
		}
		// Otherwise...
		else
		{
			// ... transition the colour back to clear.
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		
		// Reset the damaged flag.
		damaged = false;

		healthSlider.value = hp;
	}
	
	/// <summary>
	/// Inflicts damage and check if the object should be destroyed
	/// </summary>
	/// <param name="damageCount"></param>
	public void Damage(int damageCount)
	{
		damaged = true; 

		hp -= damageCount;


		
		if (hp <= 0)
		{
			// Dead!
			anim.SetBool("Dying",true);
			Destroy(gameObject);
			Application.LoadLevel(5);
			return;
		}
	}

	void PlaySound(int clip)
	{
		GetComponent<AudioSource>().clip = audioClip [clip];
		GetComponent<AudioSource>().Play ();
	}

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		// Is this a shot?
		EnemyShoot shot = otherCollider.gameObject.GetComponent<EnemyShoot>();
		if (shot != null)
		{
			// Avoid friendly fire
			if (shot.isEnemyShot != isEnemy)
			{
				Damage(shot.damage);
				
				// Destroy the shot
				Destroy(shot.gameObject); 
			}
		}
	}
}
