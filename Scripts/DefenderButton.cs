using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] GameObject myDefender;
    private DefenderSpawner spawner;

    void Start()
    {
        spawner = FindObjectOfType<DefenderSpawner>();    
    }



    void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(40, 40, 40, 255);
        }

        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        spawner.SetDefender(myDefender);
    }

}
