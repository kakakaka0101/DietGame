using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanbelController : MonoBehaviour
{

    public Rigidbody rb;

    //public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();

        rb.AddForce(new Vector3(0, 0, -Random.Range(1, 50)), ForceMode.Impulse);

        //this.GetComponent<CakesGetter>().ScoreManager = scoreManager;
    }

    // Update is called once per frame
    void Update()
    {
        //if(this.gameObject.transform.position.z <= -10)
        //{
        //    Destroy(this.gameObject);
        //}
    }
}
