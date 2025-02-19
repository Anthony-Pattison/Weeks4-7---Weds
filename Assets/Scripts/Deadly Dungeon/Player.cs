using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gob;
    public float speed;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 gobPos = gob.transform.position;
        Vector2 pos = transform.position;

        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position = pos;

        if (pos.x >= gobPos.x-1 && pos.x <= gobPos.x +1 && pos.y >= gobPos.y-1 && pos.y <= gobPos.y + 1)
        {
            score++;
        }
    }
}
