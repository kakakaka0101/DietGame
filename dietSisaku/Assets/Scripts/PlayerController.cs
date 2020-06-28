using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public AudioClip bgm;
    public AudioClip seWarp;

    AudioSource audiosource;


    // Start is called before the first frame update
    void Start()
    {
       audiosource =  GetComponent<AudioSource>();

        GetComponent<AudioSource>().PlayOneShot(bgm);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 0.02f;

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += transform.right* 2f;
            GetComponent<AudioSource>().PlayOneShot(seWarp);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))

        {
            transform.position -= transform.right * 2f;
            GetComponent<AudioSource>().PlayOneShot(seWarp);

        }

        


    }


   
}
