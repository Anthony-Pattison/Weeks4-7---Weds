using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;



public class trainpathfinding : MonoBehaviour
{
    float speed;
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

       // based on the placement of the destination the train will
       // always movetowards it
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
        // applys the movement to the train
        train.transform.position = trainPosition;
    // this long assortment of if statements take the place of a for loop that didnt end up working

    // the if statements takes the transform.position of game objects that are laid out ever turn on the tracks
    // after the train makes it to one destination on the list it moves on to the next destination
    // once the train gets to the end it rests to i == 1 which is the start of the pathfinding
        if (trainPosition.x <= destination.x + .10f && i == 0)
        {
            train.transform.eulerAngles = new Vector3(0, 0, 90);
            i = 1;
            destination = trainSpots[i].transform.position;
        }

        if (trainPosition.y < destination.y +.3f && trainPosition.y > destination.y && i == 1)
        {
            train.transform.eulerAngles = new Vector3(0, 0, 0);
            i = 2;
            destination = trainSpots[i].transform.position;
        }

        if (trainPosition.x > destination.x && trainPosition.x <= destination.x + .15f && i == 2)
        {
            train.transform.eulerAngles = new Vector3(0, 0, -90);
            i = 3;
            destination = trainSpots[i].transform.position;
        }
        if (trainPosition.y > destination.y && trainPosition.y <= destination.y + .15f && i == 3)
        {   
            train.transform.eulerAngles = new Vector3(0, 0, -180);
            i = 4;
            destination = trainSpots[i].transform.position;
        }
        if (trainPosition.x > destination.x && trainPosition.x <= destination.x + .15f && i == 4)
        {
            train.transform.eulerAngles = new Vector3(0, 0, -270);
            i = 5;
            destination = trainSpots[i].transform.position;
        }
        if (trainPosition.y < destination.y + .10f && trainPosition.y > destination.y - .30f && i == 5)
        {
            train.transform.eulerAngles = new Vector3(0, 0, 0);
            i = 6;
            destination = trainSpots[i].transform.position;
        }
        if (trainPosition.x > destination.x && trainPosition.x < destination.x + .10f && i == 6)
        {
            train.transform.eulerAngles = new Vector3(0, 0, -90);
            i = 7;
            destination = trainSpots[i].transform.position;
        }
        if (trainPosition.y > destination.y && trainPosition.y <= destination.y + .15f && i == 7)
        {
            train.transform.eulerAngles = new Vector3(0, 0, 0);
            i = 0;
            destination = trainSpots[i].transform.position;
        }
        
    }
    // uses a slider to change the speed of the train
    public void ChangeSpeed(float c)
    {
        speed = c;
    }
}
