using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankcontrol : MonoBehaviour
{
    public Sprite Sprites;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        position.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position = position;
    }
   public void Speedchange(float n)
    {
        speed = n;
    }
    public void changeSprite(bool change)
    {

        

          
        
    }
}
