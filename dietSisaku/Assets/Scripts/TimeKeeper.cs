using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeKeeper : MonoBehaviour
{

    float countTime;
    bool IsCountSound = true;
    bool IsHajimeiSound = true;
    bool IsGongSound = true;

    public float totalTime = 10;

    public Text timeTexts;
    public Text CountText;

    int retime;

    float countdown = 5f;
    int count;


    public GameObject Player;


    public GameObject fade;

    public GameObject DIns;
    public GameObject CIns;


    public AudioClip hajimei;
    public AudioClip cdAudio;
    public AudioClip gong;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;



        //Debug.Log("countTime" + countTime);


        //if(countTime >= totalTime)
        //{

        //    fade.GetComponent<FadeController>().isFadeOut = true;

        //    Invoke("LoadS", 1f);
        //}



        
        if(countdown >= 0)
        {

            
            countdown -= Time.deltaTime;
            count = (int)countdown;
            if (countdown <= 4)
            {
                CountText.text = (count).ToString();
                
                if(IsCountSound)
                {
                    GetComponent<AudioSource>().PlayOneShot(cdAudio);

                    

                    IsCountSound = false;
                }
                

            }
            if (countdown <= 1)
            {
                CountText.text = "Go!!";
                if (IsHajimeiSound)
                {
                    GetComponent<AudioSource>().PlayOneShot(hajimei);
                    Debug.Log("aaaa");

                    DIns.SetActive(true);
                    CIns.SetActive(true);

                    IsHajimeiSound = false;
                }
            }

        }

       

        if(countdown <= 0)
        {
            CountText.text = "";
            Debug.Log("iiii");
            totalTime -= Time.deltaTime;
            retime = (int)totalTime;
            timeTexts.text = (retime).ToString();

            if(retime==0)
            {
                CountText.text = "Time Up!!";
                if(IsGongSound)
                {
                    GetComponent<AudioSource>().PlayOneShot(gong);
                    IsGongSound = false;
                }


                Player.GetComponent<CapsuleCollider>().enabled = false;

                
            }
            if(retime==-1)
            {
                

                fade.GetComponent<FadeController>().isFadeOut = true;

                Invoke("LoadS", 2f);
            }
            if(retime<=-1)
            {
                timeTexts.text = "";
            }

        }


    }

    void LoadS()
    {
        SceneManager.LoadScene("GameSet");
    }
}
