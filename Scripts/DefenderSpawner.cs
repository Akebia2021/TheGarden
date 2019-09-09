using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner  : MonoBehaviour
{
    private GameObject defender;   
    private int unitCost;
    private GameState state;

    void Start()
    {
        state = FindObjectOfType<GameState>();    
    }



    //ボタンを押すとCallされる
    public void SetDefender(GameObject selected)
    {
        defender = selected;
        unitCost = defender.GetComponent<Defender>().GetCost();
               
    }

    //DefenderをSpawn
    private void OnMouseUp()
    {
        if (state.GetResources()>=unitCost)
        {
            SpawnDefender(GetClickedPosition());
        }
        else
        {
            Debug.LogError("insufficient resouces for spawning");
        }
    }

    private Vector2 GetClickedPosition()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return SnapToGrid(worldPos);
    }

    private Vector2 SnapToGrid(Vector2 rawPos)
    {
        float snappedX = Mathf.RoundToInt(rawPos.x);
        float snappedY = Mathf.RoundToInt(rawPos.y);
        return new Vector2(snappedX, snappedY);
    }

    //setされたdefenderをスポーンし、GamestateのResourcesからUnitcostを引く
    private void SpawnDefender(Vector2 worldPos)
    {
        Instantiate(defender, worldPos, Quaternion.identity);
        state.DecreaseResouces(unitCost);
    }
}
