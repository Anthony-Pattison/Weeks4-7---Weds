using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTracking : MonoBehaviour
{
    public GameObject Playerchar;
    public TextMeshProUGUI viewedScore;
    int Newscore;
    // Start is called before the first frame update
    void Start()
    {
        //viewedScore.text = Newscore.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        Newscore = Playerchar.GetComponent<Player>().score;
        viewedScore.text = Newscore.ToString();
        Debug.Log(Newscore);
    }
}
