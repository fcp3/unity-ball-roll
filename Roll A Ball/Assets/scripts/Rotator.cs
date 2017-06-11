using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// script to make Pickup object to spin
public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame (not using forces)
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime); //makes smooth and framerate independent
	}
}
