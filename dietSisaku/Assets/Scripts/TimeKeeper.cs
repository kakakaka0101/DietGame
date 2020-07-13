using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeKeeper : MonoBehaviour
{

    float countTime;

    public float rimitTime = 60;
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;

        //Debug.Log("countTime" + countTime);


        if(countTime >= rimitTime)
        {
            SceneManager.LoadScene("GameSet");
        }



    }
}
