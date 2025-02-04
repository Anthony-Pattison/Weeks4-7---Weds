using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float playerHealth = 10;
    public Slider visual;
    // Start is called before the first frame update
    void Start()
    {
        visual.value = playerHealth;
        visual.maxValue = playerHealth;
        visual.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(1);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            playerHealth = 10;
            visual.value = playerHealth;
        }
    }
    public void takeDamage(float Damage)
    {
        playerHealth -= Damage;
        visual.value = playerHealth;
    }
}
