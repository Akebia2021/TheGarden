﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    [SerializeField] private int firePower = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getFirePower()
    {
        return firePower;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var obstacle = collision.GetComponent<Attacker>();
        if (obstacle)
        {
            Destroy(gameObject);
        }
    }

}
