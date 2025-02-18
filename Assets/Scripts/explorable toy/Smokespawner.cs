using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smokespawner : MonoBehaviour
{
    bool smokeOn;
    int i = 0;
    int smokeTransparency = 255;
    public Button smokeButton;
    public GameObject TrainSmokeprefab;
    public List<GameObject> SmokeList;
    GameObject newSomke;
    // Start is called before the first frame update
    void Start()
    {
        //SomokeSpriteRenderer.color = new Color(97, 97, 97, smokeTransparency);
    }
    // Update is called once per frame
    void Update()
    {
        if (smokeOn)
        {
        smokeButton.GetComponent<Image>().color = Color.red;
            for (int i = 0; SmokeList.Count < 5; i++)
            {

                Vector2 pos = transform.position;

                pos.x -= 1f * (0.08f * i);
                newSomke = Instantiate(TrainSmokeprefab, pos, Quaternion.identity);
                Vector3 rotate = transform.eulerAngles;
                SmokeList.Add(newSomke);
                newSomke.GetComponent<SpriteRenderer>().color = Color.grey;
                Destroy(newSomke, 2);

            }

            smokeTransparency--;
            if (smokeTransparency == 0)
            {
                SmokeList.Clear();
                smokeTransparency = 255;
            }
        }
    }
    public void SmokeSwitch(bool c)
    {
        smokeOn = c;
    }
}


