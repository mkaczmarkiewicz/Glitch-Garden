using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{

    int stars = 0;
    Text starText;
    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public void AddStars()
    {
        stars += 200;
        UpdateDisplay();
    }

    public void SpendStars(int cost)
    {
        if (stars >= cost)
        {
            stars -= cost;
            UpdateDisplay();
        }
    }
}
