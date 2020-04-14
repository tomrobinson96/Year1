using UnityEngine;
using System.Collections;

public class AlienControllerScript : MonoBehaviour 
{
	public float jumpForce = 700f;
	public float maxSpeed= 10f;
	bool facingRight = true;
	bool colliding;
	public int damagePerHit = 50;

	EnemyHealth enemyHealth;
	Animator anim;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = .2f;
	public LayerMask whatIsGround;
	public Transform sightStart1;
	public Transform sightEnd1;
	public AudioClip[] audioClip;



	void Awake () 
	{
		anim = GetComponent<Animator> ();
		enemyHealth = GetComponent<EnemyHealth> ();
	}
	

	void FixedUpdate () 
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

		float move = Input.GetAxis ("Horizontal");

		anim.SetFloat ("Speed", Mathf.Abs (move));

		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}

	void Update()
	{
		anim = GetComponent<Animator> ();

		colliding = Physics2D.Linecast (sightStart1.position, sightEnd1.position);

		if(grounded && Input.GetKeyDown(KeyCode.UpArrow))
		{
			anim.SetBool("Ground", false);
			GetComponent<Rigidbody2D>().AddForce( new Vector2(0,jumpForce));
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			PlaySound(0);
			anim.SetTrigger("Punch");
			{
				if(colliding)
				{
					enemyHealth = GetComponent<EnemyHealth>();
					
					if(enemyHealth !=null)
					{
						enemyHealth.Damage(damagePerHit);

					}
				}
			}

			GetComponent<Animation>().wrapMode = WrapMode.Once;
		}

	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		bool damagePlayer = false;

		if (Input.GetKeyDown(KeyCode.Space))
		{
			// Collision with enemy
			EnemyHealth enemy = collision.gameObject.GetComponent<EnemyHealth> ();
			if (enemy != null) 
			{
			
				// Kill the enemy
			EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth> ();
			if (enemyHealth != null)
			enemyHealth.Damage (enemyHealth.currentHealth);
			
			damagePlayer = false;
			}
		}
	}

	void PlaySound(int clip)
	{
		GetComponent<AudioSource>().clip = audioClip [clip];
		GetComponent<AudioSource>().Play ();
	}

	void Flip ()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;

	}
}
