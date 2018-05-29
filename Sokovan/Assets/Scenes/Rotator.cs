using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//1초에 60도를 회전하기 위해서는 Time.deltatTIME을 넣어줘야함
		transform.Rotate(60 * Time.deltaTime ,60 * Time.deltaTime,60 * Time.deltaTime);		
	}
}
