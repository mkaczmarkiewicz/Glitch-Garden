﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    private void Start()
    {
        SetCosts();
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();

        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;

        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }

    private void SetCosts()
    {
        Text costText = GetComponentInChildren<Text>();
        if(!costText)
        {
            Debug.Log("nie dziala");
        }
        else
        {
            costText.text = defenderPrefab.GetCost().ToString();
        }
    }
}
