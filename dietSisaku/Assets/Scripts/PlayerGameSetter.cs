using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerGameSetter : MonoBehaviour
{

    public float pScale;

    // Start is called before the first frame update
    void Start()
    {
        pScale = ScoreManager.GetDietScore();

        transform.localScale = new Vector3(pScale, pScale, 100);

        Debug.Log("taijuu" + ScoreManager.GetDietScore());
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime, Space.World);
    }
}
