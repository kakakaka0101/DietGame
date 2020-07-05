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
        //if(Input.GetKey(KeyCode.Space))
        //{
            

        //}
    }

    public void Click()
    {
        //ログ出力
        Debug.Log("押したよ！");
        SceneManager.LoadScene("Game");
    }

}
