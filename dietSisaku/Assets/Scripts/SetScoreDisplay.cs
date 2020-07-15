using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScoreDisplay : MonoBehaviour
{

    Text dietScore;

    public GameObject sizeOriginObj;

    int resize;

    //public ScoreManager scoremanager;

    // Start is called before the first frame update
    void Start()
    {
        dietScore = this.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        resize = (int)sizeOriginObj.GetComponent<PlayerScaler>().sizeNow;

        dietScore.text = "体重" +  resize + "kg";
    }
}