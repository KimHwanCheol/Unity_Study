using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject winUI;
	public ItemBox[] ItemBoxs;
	// Use this for initialization

	public bool isGameOver;
	void Start () {
		isGameOver = false;
	}
	
	// Update is called once per frame
	void Update () {

		//getkey는 누르고 있는 동안
		//getkeydown은 누르는 그 순간
		if(Input.GetKeyDown(KeyCode.Space)){
			SceneManager.LoadScene("SampleScene");
		}
		if(isGameOver = true){
			return;
		}

		int count=0;
		for(int i = 0;i<ItemBoxs.Length;i++){
			if(ItemBoxs[i].isOveraped == true){
				count++;
			}
		}
		if(count == 3){
			isGameOver = true;
			winUI.SetActive(true);
		}
	}
}
