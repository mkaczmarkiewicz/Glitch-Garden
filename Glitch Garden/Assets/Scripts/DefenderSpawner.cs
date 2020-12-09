using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;
    bool defenderSet = false;
    StarDisplay starDisplay;

    GameObject defenderParent;
    const string DEFENDER_PARENT_NAME = "Defenders";

    private void Start()
    {
        starDisplay = FindObjectOfType<StarDisplay>();

        CreateDefenderParent();
    }

    private void CreateDefenderParent()
    {
        defenderParent = GameObject.Find(DEFENDER_PARENT_NAME);

        if (!defenderParent)
        {
            defenderParent = new GameObject(DEFENDER_PARENT_NAME);
        }
    }

    private void OnMouseDown()
    {
        if (defenderSet)
        {
            AttemptToPlaceDefenderAt(GetSquareClicked());
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

        starDisplay.SpendStars(defender.GetCost());

        newDefender.transform.parent = defenderParent.transform;
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

    public void AttemptToPlaceDefenderAt(Vector2 pos)
    {
        int defenderCost = defender.GetCost();

        if(starDisplay.GetStarsAmount() >= defenderCost)
        {
            SpawnDefender(pos);            
        }
    }
}
