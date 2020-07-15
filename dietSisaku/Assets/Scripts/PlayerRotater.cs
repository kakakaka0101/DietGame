using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotater : MonoBehaviour
{
    public float countTime;

    public AudioClip rolefinish;
    public AudioClip trumpet;
    public AudioClip hirari;
    public AudioClip drumrole;

    [SerializeField] private ParticleSystem particle;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(drumrole);
        Invoke("Rolefinish",4f);
        Invoke("Trumpet", 5f);
        Invoke("Hirari", 6f);
        Invoke("Ray", 6f);
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        
        if (countTime > 14f)
        {
           
            transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime, Space.World);
        }
    }

    void Rolefinish()
    {
        GetComponent<AudioSource>().PlayOneShot(rolefinish);
    }

    void Trumpet()
    {
        GetComponent<AudioSource>().PlayOneShot(trumpet);
    }

    void Hirari()
    {
        GetComponent<AudioSource>().PlayOneShot(hirari);
    }

    void Ray()
    {
        particle.Play();
    }

}
