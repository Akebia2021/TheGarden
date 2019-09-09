using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField]private  GameObject gun;

    //自分がいるLaneのSpanerへの参照
    private AttackerSpawner myLaneSpawner;

    private Animator animator;

    private void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("shoot !");
            animator.SetBool("isAttacking", true);
        }
        else
        {
            Debug.Log("wait");
            animator.SetBool("isAttacking", false);
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        
        foreach(AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough =
                (Mathf.Abs(spawner.transform.position.y - 
                transform.parent.position.y) <= Mathf.Epsilon );
            if (IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }


    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
        return;
    }
}
