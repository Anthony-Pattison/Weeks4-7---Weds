using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCurve : MonoBehaviour
{
    public AnimationCurve curve;
    float sliderEffect;
    float speed;
    public Transform start;
    public Transform end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Time.deltaTime * sliderEffect;
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(speed));
        if(speed > 1)
        {
            speed = 0;
        }
    }
    public void speedChange(float s)
    {
        sliderEffect = s;
    }
}
