﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        //ログ出力
        Debug.Log("押したよ！");

        Invoke("DelayMethod", 2f);
        //SceneManager.LoadScene("GameStart");
    }

    void DelayMethod()
    {
        SceneManager.LoadScene("GameStart");
    }

}
