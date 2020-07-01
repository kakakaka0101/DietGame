using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanbelInstancer : MonoBehaviour
{

    public GameObject cam;  //UnityでCameraPosを代入

    public Vector3 campos;

    public int randomInt;

    public GameObject cloneDanbel;
    public GameObject originDanbel;


    public float timeOut = 0.3f;
    private float timeElapsed;

    private float countTime = 0;

    public GameObject instansing;


    // Start is called before the first frame update
    void Start()
    {
        //originCake = (GameObject)Resources.Load("Cake");
    }

    // Update is called once per frame
    void Update()
    {

        countTime += Time.deltaTime;

        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            // Do anything
            randomInt = Random.Range(-1, 2);

            campos = cam.transform.position + new Vector3(randomInt * 2, 1, 70);

            this.transform.position = campos;

            cloneDanbel = Instantiate(instansing, this.transform.position, Quaternion.Euler(0f,0f,-45f));




            timeElapsed = 0.0f;
        }

        if (countTime >= 10f)
        {
            timeOut = 0.2f;
        }
        else if (countTime >= 20f)
        {
            timeOut = 0.05f;
        }


    }
}