using UnityEngine;
using System.Collections;

public class FlipWeapon : MonoBehaviour {

	bool colliding;
	public float velocity = -1f;
	public Transform sightStart;
	public Transform sightEnd;


	void Update(){

		colliding = Physics2D.Linecast (sightStart.position, sightEnd.position);

	if (colliding)
	{		
		transform.localRotation = transform.localRotation*new Quaternion(0,0,-1,0);
		velocity = 1;		
		
	}
}
}