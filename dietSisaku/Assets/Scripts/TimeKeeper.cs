using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeKeeper : MonoBehaviour
{

    float countTime;
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;

        Debug.Log("countTime" + countTime);


        if(countTime >= 60f)
        {
            SceneManager.LoadScene("GameSet");
        }



    }
}
