using UnityEngine;
using System.Collections;

public class Endlevel2 : MonoBehaviour {




	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (6);

			return;
			
		}
	}

}
