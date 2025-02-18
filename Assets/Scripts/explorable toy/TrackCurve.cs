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
        // making a speed varible that changes the speed of the ui going in berween two points
        speed = Time.deltaTime * sliderEffect;
        // uses lerp to change the position of the train tracks
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(speed));
        
    }
    // passes the slider value for speed
    public void speedChange(float s)
    {
        sliderEffect = s;
    }
}
