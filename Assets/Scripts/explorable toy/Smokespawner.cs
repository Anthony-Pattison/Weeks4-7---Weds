using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smokespawner : MonoBehaviour
{
    
    int i = 0;
    int smokeTransparency = 255;
    public SpriteRenderer SomokeSpriteRenderer;
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
        
        for (; SmokeList.Count < 5; i++) {
            Vector2 pos = transform.position;
            pos.y += 2;
            pos.x -= 1;

            
            newSomke = Instantiate(TrainSmokeprefab, pos, Quaternion.identity);
            SmokeList.Add(newSomke);
            Destroy(newSomke, 2);

        }
        
        smokeTransparency--;
        if (smokeTransparency == 0) {
            SmokeList.Clear();
            smokeTransparency = 255;
        }   
        }
}
