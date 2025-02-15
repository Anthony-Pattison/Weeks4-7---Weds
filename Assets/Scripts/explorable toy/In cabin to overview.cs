using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incabintooverview : MonoBehaviour
{
    public GameObject cabView;
    bool switchViews = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cabView.SetActive(switchViews);
    }
    public void ChangeViewsOn(bool t)
    {
        switchViews = t;
    }
    public void ChangeViewsOff(bool t)
    {
        switchViews = false;

    }
}
