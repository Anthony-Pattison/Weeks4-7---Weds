using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trainsoundeffect : MonoBehaviour
{
    public AudioSource choochoo;
    public AudioClip clip;
    int timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    // simple timer that plays a choochoo sound when completed
        timer++;
    if (timer > 2000)
        {
            timer = -1000;
            choochoo.PlayOneShot(clip);
        }
    }
}
