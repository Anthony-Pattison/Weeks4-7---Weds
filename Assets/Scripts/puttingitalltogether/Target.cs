using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public SpriteRenderer sr;
    public float speed = 1;
    public AnimationCurve curve;
    float t;
    bool isDead = false;
    public TargetSpawner spawner;
    // allows to pick a color fromt the inspector
    public Color col;
    private void Start()
    {
        speed = Random.Range(-5, 5);
        if (speed == 0)
        {
            speed = 1;
        }
    }
    private void Update()
    {
        Vector2 pos = transform.position;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        pos.x += speed * Time.deltaTime;
        if (screenPos.x < 0)
        {
            speed = speed * -1;
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x;
        }
        if (screenPos.x > Screen.width)
        {
            speed = speed * -1;
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,0)).x;
        }
        transform.position = pos;

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // if the mouse is inside the bounds of the sprite
            if (sr.bounds.Contains(mousePos))
            {
                sr.color = col;
                isDead = true;
                spawner.TargetsHit(gameObject);
            }

        }
        if (isDead == true)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * curve.Evaluate(t);
            Destroy(gameObject, 1);
        }
    }
}
