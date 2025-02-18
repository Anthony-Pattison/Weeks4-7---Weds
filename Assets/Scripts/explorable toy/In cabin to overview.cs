using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incabintooverview : MonoBehaviour
{
    // call to to the UI the draws the inside of the train
    public GameObject cabView;
    bool switchViews = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // turns off and on the UI 
        // makes the user go from inside the train to outside
        cabView.SetActive(switchViews);
    }
    // takes input from a UI button turn the view on
    public void ChangeViewsOn(bool t)
    {
        switchViews = t;
    }
    // takes input from a UI button turn the view off
    public void ChangeViewsOff(bool t)
    {
        switchViews = false;

    }
}
