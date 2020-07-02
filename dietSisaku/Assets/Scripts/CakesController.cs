using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public ScoreManager scoreManager;

public class CakesController : MonoBehaviour
{

    public Rigidbody rb;

    //public ScoreManager scoreManager;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();

        rb.AddForce(new Vector3(0, 0, -Random.Range(1, 50)),ForceMode.Impulse);

        //this.GetComponent<CakesGetter>().ScoreManager = scoreManager;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
