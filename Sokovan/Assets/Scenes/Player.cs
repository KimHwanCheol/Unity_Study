using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 10f;
	public Rigidbody playerRigidbody;


	// Use this for initialization
	void Start () {
		playerRigidbody.AddForce(0,1000,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
