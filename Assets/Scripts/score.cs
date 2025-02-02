using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class score : MonoBehaviour
{
    public GameObject gameOverScreen;
    public TextMeshProUGUI Score;
    private int scoreValue = 0;
    private bool gameState = true;
    public void Update()
    {
        if (gameState)
        {
            if (Input.GetMouseButtonDown(0))
            {
                scoreValue++;
                Score.text = scoreValue.ToString();

            }
        }
        if (scoreValue >= 10)
        {
           gameOverScreen.SetActive(true);
            gameState = false;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            scoreValue = 0;
            Score.text = scoreValue.ToString();
            gameOverScreen.SetActive(false);
            gameState = true;
        }
    }
}
