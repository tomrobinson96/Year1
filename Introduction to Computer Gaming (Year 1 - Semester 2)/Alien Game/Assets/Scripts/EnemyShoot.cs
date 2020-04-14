using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

	public int damage = 10;
	public bool isEnemyShot = false; 
	bool colliding;
	public Transform sightStart;
	public Transform sightEnd;



	// Use this for initialization
	void Start () {
		Destroy (gameObject, 2);
	
	}

	void Update(){
				colliding = Physics2D.Linecast (sightStart.position, sightEnd.position);
		
				if (colliding) {		
			transform.localScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);						
			
				}
		}
	

}
