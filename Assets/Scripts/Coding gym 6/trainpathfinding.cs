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
        for (int i = 0; i < trainSpots.Count; i++)
        {
            Vector2 destination = trainSpots[i].transform.position;
            
                Debug.Log(i);
                if (trainPosition.x > destination.x)
                {
                    trainPosition.x = trainPosition.x - speed * Time.deltaTime;
                }
                if (trainPosition.x < destination.x)
                {
                    trainPosition.x = trainPosition.x + speed * Time.deltaTime;
                }
                if (trainPosition.y > destination.y)
                {
                    trainPosition.y = trainPosition.y - speed * Time.deltaTime;
                }
                if (trainPosition.y < destination.y)
                {
                    trainPosition.y = trainPosition.y + speed * Time.deltaTime;
                }
            
            train.transform.position = trainPosition;
            
            }
    }
}
