using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    public GameObject can;
    public GameObject sodacan;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        can.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.z = 0;
        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position = pos;

        if(pos.x >= sodacan.transform.position.x)
        {
            can.SetActive(true);
        }
        else
        {
            can.SetActive(false);
        }
        if (can == true && Input.GetKey(KeyCode.Space))
        {
            Debug.Log("HELLO im a coke can :)");
            
        }
    }
}
