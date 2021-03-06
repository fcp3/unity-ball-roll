﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

	// Creates a Rigidbody object to get component of object
	private Rigidbody rb;

	private int pickupCnt;


	// Variable that can be changed in Unity Engine
	public float speed;
	public Text scoreText;
	public Text winText;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		pickupCnt = 0;
		SetScoreText ();
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Used for physics of object
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	// used to consume the pickups
	void OnTriggerEnter (Collider other) {
		
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false);
			pickupCnt = pickupCnt + 1;
			SetScoreText ();
		}

	}

	void SetScoreText () {
		scoreText.text = "Score: " + pickupCnt.ToString ();
		if (pickupCnt >= 12) {
			winText.text = "You've won!";
		}
	}

}
