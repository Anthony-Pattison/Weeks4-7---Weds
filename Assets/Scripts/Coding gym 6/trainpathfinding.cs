using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Apple;
using static UnityEditor.PlayerSettings;

public class trainpathfinding : MonoBehaviour
{
    public float speed = 5;
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
        for (int i = 0; i < 7; i++)
        {
            Vector2 destination = trainSpots[i].transform.position;
            trainSpots[i].transform.position = destination;
            if (trainPosition.x > destination.x)
            {
                Debug.Log(trainSpots);
                trainPosition.x = trainPosition.x - speed * Time.deltaTime;
                train.transform.position = trainPosition;
            }
        }
    }
}
