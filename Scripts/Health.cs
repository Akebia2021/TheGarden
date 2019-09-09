using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //この値はアタッチされるPrefabごとに異なるように設定される
    [SerializeField] float health = 100f;

    //ヘルスを減少
    public void ProcessDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            return;
        }
    }

    public float GetHealth()
    {
        return health;
    }
}
