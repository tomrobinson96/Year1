﻿using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {
	public float objectSpeed = -0.5f;
	
	void Update () {
		transform.Translate(0, 0, objectSpeed);
	}
}