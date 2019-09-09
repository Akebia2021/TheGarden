using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerMovement : MonoBehaviour
{
    private Attacker attacker;
    // Start is called before the first frame update
    void Start()
    {
        attacker = GetComponentInParent<Attacker>();
    }

// Update is called once per frame
    void Update()
    {

    }


    public void SetMovementSpeed(float speed)
    {
        attacker.SetMovementSpeed(speed);
    }

}
