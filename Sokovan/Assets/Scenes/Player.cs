﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 10f;
	private Rigidbody playerRigidbody;


	// Use this for initialization
	//게임이 처음 시작되었을때 한번
	void Start () {
		playerRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	//화면이 한번 깜빡일때 한번 실행
	void Update () {
		
		//-1 ~ +1
		//Horizontal 키보드 수평방향에 대응되는 키가 대응되어있음.
		float inputX = Input.GetAxis("Horizontal");

		float inputZ = Input.GetAxis("Vertical");

		float fallSpeed = playerRigidbody.velocity.y;
		
		Vector3 velocity = new Vector3(inputX,0,inputZ);
		velocity = velocity * speed;

		velocity.y = fallSpeed;

		playerRigidbody.velocity = velocity;
	}
}
