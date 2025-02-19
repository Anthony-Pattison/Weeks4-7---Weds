using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasermovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 POS = transform.position;
        POS.y -= 1 * Time.deltaTime;
        if (POS.y < -10) {
            POS.y = 11;
        }
        transform.position = POS;
    }
}
