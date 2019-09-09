using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cockatrice : MonoBehaviour
{
    


    //あたった相手がDefenderならフラグをIsAttackingにセットし移動を停止し攻撃Animatorを開始
    //この関数はCollisionに入った時に一度だけ呼ばれる。OnCollisionStayだと衝突中はずっとよばれる
    private void OnTriggerEnter2D(Collider2D OtherCollider)
    {
        Debug.Log("enemy collide defender");
        GameObject otherObject = OtherCollider.gameObject;

        if (otherObject.GetComponent<Defender>())
        {
            gameObject.GetComponent<Attacker>().Attack(otherObject);
            
        }
    }


}
