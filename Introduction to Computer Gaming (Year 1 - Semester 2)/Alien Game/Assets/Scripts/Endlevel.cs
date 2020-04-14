using UnityEngine;
using System.Collections;

public class Endlevel1 : MonoBehaviour {




	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (3);

			return;
			
		}
	}

}
