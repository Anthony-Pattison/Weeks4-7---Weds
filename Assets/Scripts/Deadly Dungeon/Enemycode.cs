using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float speed = 2;
    float currentSpeedY;
    float currentSpeedX;
    public GameObject Playercahr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 EnemyPos = transform.position;
        Vector2 Playerpos = Playercahr.transform.position;
        if (EnemyPos.x > Playerpos.x)
        {
            currentSpeedX -= speed * Time.deltaTime;
        }
        if (EnemyPos.x < Playerpos.x)
        {
            currentSpeedX += speed * Time.deltaTime;
        }
        if (EnemyPos.y > Playerpos.y)
        {
            currentSpeedY -= speed * Time.deltaTime;
        }
        if (EnemyPos.y < Playerpos.y)
        {
            currentSpeedY += speed * Time.deltaTime;
        }
        EnemyPos.x = currentSpeedX;
        EnemyPos.y = currentSpeedY;
        transform.position = EnemyPos;
    }
}
