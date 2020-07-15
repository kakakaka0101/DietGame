using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowtoDisplay : MonoBehaviour
{
    public GameObject howtoImage;

    public AudioClip decision;

    public AudioClip onSelect;

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
        howtoImage.gameObject.SetActive(!howtoImage.gameObject.activeSelf);

        this.GetComponent<AudioSource>().PlayOneShot(decision);

        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(ScoreManager.GetDietScore());
        
    }

    public void OnSelect()
    {
        this.GetComponent<AudioSource>().PlayOneShot(onSelect);
    }

}
