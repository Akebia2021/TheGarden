using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    [SerializeField] int life = 1000;
    [SerializeField] int resources = 300;
    [SerializeField] int supplyPerSeconds = 10;
    private bool gamestate = true;


    void Start()
    {
        StartCoroutine(SupplyResource());
    }
        

    IEnumerator SupplyResource()
    {
        while (gamestate)
        {
            resources += supplyPerSeconds;
            yield return new WaitForSeconds(1f);

        }
    }

    public void DecreaseResouces(int cost)
    {
        resources -= cost;
    }

    public int GetResources()
    {
        return resources; 
    } 
}
