using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //    if(Input.GetKey(KeyCode.Space))
    //    {
    //        SceneManager.LoadScene("Game");

    //    }
    }

    public void Click()
    {
        Debug.Log("押したよ！");
        SceneManager.LoadScene("Game");

        //Invoke("GameStart", 0.3f);
        
    }

    //public void GameStart()
    //{
    //    SceneManager.LoadScene("Game");
    //}

}
 

