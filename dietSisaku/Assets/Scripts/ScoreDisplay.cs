using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{

    public Text dietScore;

    //public ScoreManager scoremanager;

    // Start is called before the first frame update
    void Start()
    {
        dietScore = this.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        dietScore.text = "ダイエットスコア" + ScoreManager.GetDietScore() + "kg";
    }
}
