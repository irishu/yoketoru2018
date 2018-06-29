using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    int score;

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //Oキーが押されたか判定
        if (Input.GetKeyDown(KeyCode.O))
        {
            //マルチシーンで、GameOverシーンを読み込む
            SceneManager.LoadScene("GameOver",LoadSceneMode.Additive);
        }

        //Aキーが押されたら点数を入れる
        if(Input.GetKey(KeyCode.A))
        {
            score += 10;
            Debug.Log(score);
        }
	}
}
