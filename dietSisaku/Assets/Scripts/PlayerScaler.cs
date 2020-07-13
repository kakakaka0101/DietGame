using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
    public float taijuu;
    public float sabun;
    public float sizeNow=100;
    public float sizeVelocity= 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        taijuu = ScoreManager.GetDietScore();

        sabun = taijuu - 100;

        sizeVelocity = sabun / 4;
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if(sizeNow >taijuu+1 || sizeNow < taijuu)
        {
            transform.localScale += new Vector3(sizeVelocity*Time.deltaTime, sizeVelocity*Time.deltaTime, 0);
            sizeNow += sizeVelocity* Time.deltaTime;
            Debug.Log("SIZE=" + sizeNow);
        }
       

    }

}
