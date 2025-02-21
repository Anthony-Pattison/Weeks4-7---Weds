using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject TargetPreFab;
    public int HowManyObjects = 5;
    public GameObject victory;
    public GameObject canvus;
    public List<GameObject> Targets;
    private void Start()
    {  
     BeginGame();
    }
    private void Update()
    {
        if (Targets.Count == 0)
        {
            victory.SetActive(true);
            canvus.SetActive(true);
        }
    }
public void TargetsHit( GameObject t)
    {
        Targets.Remove(t);
    }
    public void BeginGame()
    {
        victory.SetActive(false);
        canvus.SetActive(false);
        Targets = new List<GameObject>();
        for (int i = 0; i < HowManyObjects; i++)
        {
            GameObject NewTarget = Instantiate(TargetPreFab);
            NewTarget.transform.position = Random.insideUnitCircle * 5;
            Target t = NewTarget.GetComponent<Target>();
            t.spawner = this;
            Targets.Add(NewTarget);
        }
    }
}
