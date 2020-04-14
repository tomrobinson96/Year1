using UnityEngine;
using System.Collections;

public class Endlevel : MonoBehaviour {




	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (2);

			return;
			
		}
	}

}
