using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Base : MonoBehaviour
{
    int health = 5;

    [SerializeField] Text textHealth;
    [SerializeField] GameObject loseScreen;
    [SerializeField] GameObject buttons;
    [SerializeField] Slider mySlider;
    [SerializeField] GameObject starDisplay;

    private void Start()
    {
        UpdateHealthScore();
        loseScreen.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Attacker")
        {
            health--;
            UpdateHealthScore();
        }

        if (health <= 0)
        {
            ShowLoseScreen();
        }
    }

    private void UpdateHealthScore()
    {
        textHealth.text = health.ToString();
    }

    private void ShowLoseScreen()
    {
        loseScreen.SetActive(true);
        textHealth.gameObject.SetActive(false);
        buttons.SetActive(false);
        mySlider.gameObject.SetActive(false);
        starDisplay.SetActive(false);
    }
}
