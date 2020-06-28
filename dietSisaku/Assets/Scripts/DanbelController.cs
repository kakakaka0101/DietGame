using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanbelController : MonoBehaviour
{

    public int numI = 10; //アイテムの数

    public GameObject[] originDanbel;

    public GameObject cloneDanbel;

    public Vector3 randomT;

    public int randomInt;
    public int randomSpeed;

    public ScoreManager scoreManager;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {


        originDanbel = new GameObject[numI];



        for (int i = 0; i < numI; i++)
        {
            originDanbel[i] = (GameObject)Resources.Load("danbel");

            randomInt = Random.Range(-1, 2);

            randomT = new Vector3(randomInt * 2, 1, Random.Range(-45f, 200f));

            cloneDanbel = Instantiate(originDanbel[i], randomT,Quaternion.Euler(0f,0f,-45f));

            cloneDanbel.transform.parent = this.transform;

            rb = cloneDanbel.GetComponent<Rigidbody>();

            randomSpeed = Random.Range(1, 10);

            rb.AddForce(0, 0, -1f * randomSpeed, ForceMode.Impulse);


            cloneDanbel.GetComponent<DanbelGetter>().ScoreManager = scoreManager;

        }
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position -= transform.forward * 0.01f;




    }



}
