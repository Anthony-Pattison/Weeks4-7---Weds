using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginGame : MonoBehaviour
{
    public TargetSpawner spawner;
    public SpriteRenderer srr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (srr.bounds.Contains(mousePos) && Input.GetMouseButtonDown(0))
        {
            spawner.BeginGame();
        }
    }
}
