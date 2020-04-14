using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int startingHealth = 100;
	public int currentHealth;
	public int scoreValue;


	Animator anim;
	bool isDead;


	void Awake()
	{
		anim = GetComponent<Animator> ();
		currentHealth = startingHealth;
	}

	public void Damage(int damageCount)
	{
		currentHealth -= damageCount;
		
		if (currentHealth <= 0)
		{
			// Dead!
			Destroy(gameObject);
			return;
		}
	}

	void Death()
	{
		isDead = true;

		//CircleCollider2D.isTrigger = true;
		anim.SetBool ("Dead", true);
	}

}
