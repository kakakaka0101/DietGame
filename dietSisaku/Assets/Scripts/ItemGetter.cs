using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGetter : MonoBehaviour
{

    public AudioClip apple;

    public ScoreManager ScoreManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private object OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            GetComponent<AudioSource>().PlayOneShot(apple);
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;

            //Destroy(this.gameObject);


            ScoreManager.MoredietScore;


           


        }
    }

}
