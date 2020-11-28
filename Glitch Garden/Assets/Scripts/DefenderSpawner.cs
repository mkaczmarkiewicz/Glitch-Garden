using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;
    bool defenderSet = false;

    private void OnMouseDown()
    {
        if (defenderSet)
        {
            SpawnDefender(GetSquareClicked());
        }
    }

    public void SetSelectedDefender(Defender selectedDefender)
    {
        defender = selectedDefender;
        defenderSet = true;
    }
    
    private void SpawnDefender(Vector2 mousePos)
    {
        Defender newDefender = Instantiate(defender, mousePos , Quaternion.identity) as Defender;
    }

    private Vector2 SnapToGrip(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);

        return new Vector2(newX, newY);
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrip(worldPos);
        return gridPos;
    }
}
