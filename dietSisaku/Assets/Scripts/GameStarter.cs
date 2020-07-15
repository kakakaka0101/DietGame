using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStarter : MonoBehaviour
{

    public GameObject fade;

    public AudioClip decision;

    public AudioClip onSelect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.Space))
        //{
            

        //}
    }

    public void Click()
    {
        //ログ出力
        Debug.Log("押したよ！");

        this.GetComponent<AudioSource>().PlayOneShot(decision);

        fade.GetComponent<FadeController>().isFadeOut = true;


        Invoke("LoadS",1f);
    }

    void LoadS()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnSelect()
    {
        this.GetComponent<AudioSource>().PlayOneShot(onSelect);
    }

}
