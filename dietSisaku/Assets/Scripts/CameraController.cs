using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float countTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        transform.position += transform.forward * 0.02f;

        countTime += Time.deltaTime;
        if (countTime >= 10)
        {
            transform.position += transform.forward * 0.02f;
        }
        if (countTime >= 20)
        {
            transform.position += transform.forward * 0.02f;
        }


    }
}
