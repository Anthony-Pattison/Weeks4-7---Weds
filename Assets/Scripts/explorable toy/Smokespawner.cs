using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smokespawner : MonoBehaviour
{

    public GameObject TrainSmokeprefab;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
            Vector2 pos = transform.position;
        pos.y += 2;
        pos.x -= 1;
            if (Input.GetMouseButtonDown(0))
            {
           
                Instantiate(TrainSmokeprefab, pos, Quaternion.identity);
            }
       

    }
}
