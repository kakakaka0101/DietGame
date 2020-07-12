using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingDisplay : MonoBehaviour
{

    public GameObject ranking;


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
        ranking.gameObject.SetActive(!ranking.gameObject.activeSelf);
    }

}
