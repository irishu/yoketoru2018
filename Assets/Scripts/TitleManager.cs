﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TitleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//クリックされたか
        if(Input.GetMouseButtonDown(0))
        {
            //Gameシーンを読み込む
            SceneManager.LoadScene("Game");
            //Debug.Log("クリック");
        }
	}
}
