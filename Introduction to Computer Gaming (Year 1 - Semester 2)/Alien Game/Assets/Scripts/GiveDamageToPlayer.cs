//using UnityEngine;
//using System.Collections;
//
//public class GiveDamageToPlayer : MonoBehaviour {
//
//	public int DamageToGive = 10;
//
//	private Vector2
//		lastposition,
//		velocity;
//
//	public void LateUpdate()
//	{
//		velocity = (lastposition - (Vector2)transform.position) / Time.deltaTime;
//		lastposition = transform.position;
//	}
//
//	public void OnTriggerEnter2D(Collider2D other)
//	{
//		var player = other.GetComponent<PlayerHealth> ();
//		if (player == null)
//						return;
//
//		player.TakeDamage1 (DamageToGive);
//		var controller = player.GetComponent<CharacterController> ();
//		var totalVelocity = controller.velocity + velocity;
//
//		controller.SetForce (new Vector2 (
//			-1 * Mathf.Sign (totalVelocity.x) * Mathf.Clamp (Mathf.Abs (totalVelocity.x) * 5, 10, 20),
//			-1 * Mathf.Sign (totalVelocity.y) * Mathf.Clamp (Mathf.Abs (totalVelocity.y) * 2, 10, 15)));
//
//	}
//}
