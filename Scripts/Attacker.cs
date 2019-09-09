using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour

{


    //[Range(0f, 5f)][SerializeField] private float walkSpeed = 1f;
    [SerializeField] private float currentSpeed = 1f;

    [SerializeField] private int cost = 100;

    [SerializeField] float hitPower = 50;
    [SerializeField] float hitFrequency = 5f;

    private GameObject currentTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);

    }



    //矢からダメージを受け取ってHealthをへらす
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Arrow>()) {
            var damage = collision.GetComponent<Arrow>().getFirePower();
            gameObject.GetComponent<Health>().ProcessDamage(damage);
        }
        
        
    }

    

    public int GetCost()
    {
        return cost;
    }

    public void SetMovementSpeed(float speed)
    {
        Debug.Log("current speed " + currentSpeed);
        currentSpeed = speed;
    }
    public void SetCurrentTarget(GameObject targe)
    {
        currentTarget = targe;
    }

    //攻撃モーションへの移行フラグをセット
    public void Attack(GameObject target)
    {
        GetComponentInChildren<Animator>().SetBool("IsAttacking", true);
        SetCurrentTarget(target);
        StartCoroutine(Strike());
    }

    //攻撃モーションへの移行フラグを解除(Walkへ移行)
    public void NotAttack()
    {
        GetComponentInChildren<Animator>().SetBool("IsAttacking", false);
    }


    //現在のターゲットを攻撃
    public void StrikeCurrentTarget(float damage)
    {
        if (!currentTarget)
        {
            return;
        }
        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            health.ProcessDamage(damage);
        }
    }

    IEnumerator Strike()
    {
        //少し遅れが生じてしまう。Updateで
        while (currentTarget)
        {
            StrikeCurrentTarget(hitPower);
            yield return new WaitForSeconds(hitFrequency);
        }
        NotAttack();

        
    }

     
}
