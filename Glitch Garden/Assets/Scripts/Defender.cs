using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    int cost = 100;
    StarDisplay starDisplay;

    private void Start()
    {
        starDisplay = FindObjectOfType<StarDisplay>();
    }

    public void AddStars()
    {
        starDisplay.AddStars();
    }

    public int GetCost()
    {
        return cost;
    }

    
}
