﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int dietScore=100;

    public Text sc;


    [SerializeField] private GameObject textobj;



    // Start is called before the first frame update
    void Start()
    {
        dietScore = 100;

        sc = textobj.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        sc.text = dietScore + "kg";

    }

    public int MoredietScore()
    {
        dietScore += 1;

        return dietScore;
    }

    public int LessdietScore()
    {
        dietScore -= 1;

        return dietScore;

    }

    public static int GetDietScore()
    {
        return dietScore;
    }


}
