﻿using System.Collections;

using System.Collections.Generic;

using UnityEngine;

//UI使うときに必要

using UnityEngine.UI;



public class ButtonChoice : MonoBehaviour

{

    Button button;



    void Start()

    {

        button = GameObject.Find("Canvas/ButtonSummary/StartButton").GetComponent<Button>();

        //ボタンが選択された状態になる

        button.Select();

    }

}