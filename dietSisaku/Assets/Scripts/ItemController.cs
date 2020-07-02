using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{

    public int numI = 10; //アイテムの数

    public GameObject[] originItem;

    public GameObject cloneItem;

    public Vector3 randomT;

    public int randomInt;
    public int randomSpeed;

    public ScoreManager scoreManager;

    public Rigidbody rb;

    float countTime;

    // Start is called before the first frame update
    void Start()
    {
     

        originItem = new GameObject[numI];



        for (int i = 0; i < numI; i++)
        {
            originItem[i] = (GameObject)Resources.Load("Karaage");

            randomInt = Random.Range(-1,2);

            randomT = new Vector3(randomInt*2, 1, Random.Range(-45f, 100f));

            cloneItem = Instantiate(originItem[i], randomT, Quaternion.identity);

            cloneItem.transform.parent = this.transform;

            rb = cloneItem.GetComponent<Rigidbody>();

            randomSpeed = Random.Range(1, 10);

            rb.AddForce(0, 0, -1f*randomSpeed,ForceMode.Impulse);


            cloneItem.GetComponent<ItemGetter>().ScoreManager = scoreManager;

        }
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position -= transform.forward * 0.01f;

        countTime += Time.deltaTime;


        if (countTime >= 10f)
        {
            this.GetComponent<Rigidbody>().AddForce(0, 0, -1f * randomSpeed);

           
        }


    }



}
