using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Apple;
using static UnityEditor.PlayerSettings;

public class trainpathfinding : MonoBehaviour
{
    public float speed = 5;
    int i = 0;
    public GameObject train;
    public List<GameObject> trainSpots;
    // Start is called before the first frame update
    void Start()
    {



    }
    // Update is called once per frame
    void Update()
    {
        Vector2 trainPosition = train.transform.position;

        Vector2 destination = trainSpots[i].transform.position;

        Debug.Log(i);

        if (trainPosition.x > destination.x)
        {
            trainPosition.x -= speed * Time.deltaTime;
        }
        if (trainPosition.x < destination.x)
        {
            trainPosition.x += speed * Time.deltaTime;
        }
        if (trainPosition.y > destination.y)
        {
            trainPosition.y -= speed * Time.deltaTime;
        }
        if (trainPosition.y < destination.y)
        {
            trainPosition.y += speed * Time.deltaTime;
        }

        train.transform.position = trainPosition;

        if (trainPosition.x <= destination.x + .10f && i == 0)
        {
            i = 1;
            destination = trainSpots[i].transform.position;
        }

        if (trainPosition.y < destination.y +.3f && trainPosition.y > destination.y && i == 1)
        {
            i = 2;
            destination = trainSpots[i].transform.position;
        }

        if (trainPosition.x > destination.x && trainPosition.x <= destination.x + .15f && i == 2)
        {
            i = 3;
            destination = trainSpots[i].transform.position;
        }
        if (trainPosition.y > destination.y && trainPosition.y <= destination.y + .15f && i == 3)
        {
            i = 4;
            destination = trainSpots[i].transform.position;
        }
        if (trainPosition.x > destination.x && trainPosition.x <= destination.x + .15f && i == 4)
        {
            i = 5;
            destination = trainSpots[i].transform.position;
        }
        if (trainPosition.y < destination.y + .10f && trainPosition.y > destination.y - .30f && i == 5)
        {
            i = 6;
            destination = trainSpots[i].transform.position;
        }
        if (trainPosition.x > destination.x && trainPosition.x < destination.x + .10f && i == 6)
        {
            i = 7;
            destination = trainSpots[i].transform.position;
        }
        if (trainPosition.y > destination.y && trainPosition.y <= destination.y + .15f && i == 7)
        {
            i = 0;
            destination = trainSpots[i].transform.position;
        }

    }
}
