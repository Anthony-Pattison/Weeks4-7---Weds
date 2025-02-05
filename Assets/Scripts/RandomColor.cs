using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void randomcolo()
    {
        //Color randomColor = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
        GetComponent<SpriteRenderer>().color = Random.ColorHSV();
       
    }
    public void rotate(float t)
    {
        Vector3 rotations = transform.eulerAngles;
        rotations.z -= t;
        transform.eulerAngles = rotations;
       
    }
}
