using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	private Weapon weapon;

	public float velocity = -1f;
	public bool colliding;
	public Transform sightStart;
	public Transform sightEnd;




	// Use this for initialization
	void Start () {
		GetComponent<Animation>().GetComponent<Animator> ();
		weapon = GetComponentInChildren<Weapon>();

	}
	
	// Update is called once per frame
	void Update () {
	

		GetComponent<Rigidbody2D>().velocity = new Vector2 (velocity, GetComponent<Rigidbody2D>().velocity.y);

		colliding = Physics2D.Linecast (sightStart.position, sightEnd.position);

		if (colliding)
		{

				transform.localScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);
				velocity *= -1;
				
		}
		if (weapon != null && weapon.CanAttack)
		{
			weapon.Attack(true);
		}

	}


	void OnDrawGizmos()
	{
				Gizmos.color = Color.magenta;

				Gizmos.DrawLine (sightStart.position, sightEnd.position);
		}

}


