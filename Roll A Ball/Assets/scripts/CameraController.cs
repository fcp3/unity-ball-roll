using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// script locking camera to player object
public class CameraController : MonoBehaviour {

	//references player object
	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is guaranteed to run after all items have been processed to run
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}


}
