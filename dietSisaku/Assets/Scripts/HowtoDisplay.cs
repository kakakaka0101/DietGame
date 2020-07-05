using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowtoDisplay : MonoBehaviour
{
    public GameObject howtoImage;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        Debug.Log("押したよ！!");

      

        howtoImage.gameObject.SetActive(!howtoImage.activeSelf);

    }

}
