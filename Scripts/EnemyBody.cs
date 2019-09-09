using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBody : MonoBehaviour


{
    


    //Foo foo = transform.parent.gameobject.getcomponent<foo>()
    private Attacker attacker;

    // Start is called before the first frame update
    void Start()
    {
        attacker = transform.parent.GetComponent<Attacker>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSpeedCallParent(float speed)
    {
        attacker.SetMovementSpeed(speed);
    }

  
    
    

}
