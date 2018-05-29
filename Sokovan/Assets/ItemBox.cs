using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour {

	private Renderer myRenderer;

	public Color touchColor;
	private Color originalColor;

	// Use this for initialization
	void Start () {
		myRenderer = GetComponent<Renderer>();
		originalColor = myRenderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    //유니티가 자동으로 충돌을 감지하여 onTriggerEnter 함수를 호출
	//트리거인 콜라이더와 충돌할때 자동으로 실행
	//Enter는 충돌을 한 그 순간
	void OnTriggerEnter(Collider other){
		if(other.tag == "EndPoint"){
			myRenderer.material.color = touchColor;
		}
	
	}

	//Exit는 붙어있다가 떼어질때
	void OnTriggerExit(Collider other){
		if(other.tag == "EndPoint"){
			myRenderer.material.color = originalColor;
		}
	}


	//Stay는 충돌하고 있는 동안 혹은 붙어있는 동안
	void OnTriggerStay(Collider other){
		if(other.tag == "EndPoint"){
			myRenderer.material.color = touchColor;
		}
	}
	
	/*
	//통과할 수 없는 일반 콜라이더와 충돌했을 때 자동으로 실행

	void OnCollisionEnter(Collision other){

	}
	 */
}
