using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smokespawner : MonoBehaviour
{
    bool smokeOn;
    int smokeTransparency = 255;

    public Button smokeButton;
    public GameObject TrainSmokeprefab;
    // creates a list for the smoke prefabs game objects
    public List<GameObject> SmokeList;

    GameObject newSomke;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // only runs update function if the smoke is on
        if (smokeOn)
        {
            // change the button to red to show the user that something changed
            smokeButton.GetComponent<Image>().color = Color.red;
            // for loop the runs so there is 5 smoke sprites on screen
            for (int i = 0; SmokeList.Count < 5; i++)
            {
                // the static place value of where the train was
                // so the smoke doesn't follow the train
                Vector2 pos = transform.position;
                // change of x position so they arn't drawn ontop of eachother
                pos.x -= 1f * (0.08f * i);
                // makes a game object based on the prefab given
                newSomke = Instantiate(TrainSmokeprefab, pos, Quaternion.identity);
                // giving the rotation after the Quaternion.identity was assigned so the smoke
                // is drawn what the train is upside down
                Vector3 rotate = transform.eulerAngles;
                newSomke.GetComponent<SpriteRenderer>().color = Color.grey;

                // add the game object to the list
                SmokeList.Add(newSomke);

                // destroy the set of smoke after 2 second off being spawned
                Destroy(newSomke, 2);

            }
            // timer for the smoke list being cleared
            smokeTransparency--;
            if (smokeTransparency == 0)
            {
                SmokeList.Clear();
                smokeTransparency = 255;
            }
        }
    }
    // passes a booleon to turn the smoke on
    public void SmokeSwitch(bool c)
    {
        smokeOn = c;
    }
}


