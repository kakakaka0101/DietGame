using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakesGetter : MonoBehaviour
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

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            GetComponent<AudioSource>().PlayOneShot(apple);
            //this.GetComponent<MeshRenderer>().enabled = false;
            this.transform.localScale = new Vector3(0f, 0f, 0f);
            this.GetComponent<CapsuleCollider>().enabled = false;
            

            ScoreManager.MoredietScore();
            


        }
     
    }

}
