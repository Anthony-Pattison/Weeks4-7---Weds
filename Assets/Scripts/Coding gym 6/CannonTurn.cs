using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class CannonTurn : MonoBehaviour
{
    public GameObject prefab;
    public List<GameObject> missles;
    public float Speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 rotate = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rotate.y = 0;
        Vector3 finalrotation = Vector3.zero;
        finalrotation.z = -rotate.x * 30;
        if (finalrotation.z >= 115 )
        {
        finalrotation.z = 115;
        }
        if (finalrotation.z <= -13)
        {
            finalrotation.z = -13;
        }

        if (Input.GetMouseButtonDown(0)) {
            GameObject miscMissle = Instantiate(prefab, rotate, Quaternion.identity);
            miscMissle.transform.position = transform.position;
            miscMissle.transform.eulerAngles = transform.eulerAngles;
            missles.Add(miscMissle);
            }

       

        transform.eulerAngles = finalrotation;
    }
}
