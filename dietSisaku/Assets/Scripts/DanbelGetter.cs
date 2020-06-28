using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanbelGetter : MonoBehaviour
{

    public AudioClip ou;

    public ScoreManager ScoreManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            GetComponent<AudioSource>().PlayOneShot(ou);

            //this.GetComponent<MeshRenderer>().enabled = false;
            this.transform.localScale = new Vector3(0f, 0f, 0f);

            this.GetComponent<BoxCollider>().enabled = false;

            //Destroy(this.gameObject);

            ScoreManager.lessdietScore();


            


        }
    }

}

