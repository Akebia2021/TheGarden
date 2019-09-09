using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{

    [SerializeField] int health = 300;
    [SerializeField] int cost = 100;

    public int GetCost()
    {
        Debug.Log("getcost");
        return cost;
    }
    public int GetHealth()
    {
        return health;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
