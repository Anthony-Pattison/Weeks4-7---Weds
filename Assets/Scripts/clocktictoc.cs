using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clocktictoc : MonoBehaviour
{
    public int speed = 20;
    public AudioSource clip;
    public AudioClip tiktok;
    int timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 turn = transform.eulerAngles;
        turn.z -= speed * Time.deltaTime;
        transform.eulerAngles = turn;
        if(turn.z%30 >= 29.95)
        {
            
           
            clip.PlayOneShot(tiktok);
        }
        Debug.Log(turn.z % 30);
    }
}
