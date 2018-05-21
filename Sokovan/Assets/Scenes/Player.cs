using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 10f;
	public Rigidbody playerRigidbody;


	// Use this for initialization
	//게임이 처음 시작되었을때 한번
	void Start () {

	}
	
	// Update is called once per frame
	//화면이 한번 깜빡일때 한번 실행
	void Update () {
		Debug.Log("화면이 한번 깜빡임");
	}
}
