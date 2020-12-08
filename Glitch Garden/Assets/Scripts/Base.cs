using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Base : MonoBehaviour
{
    int health;

    [SerializeField] Text textHealth;
    [SerializeField] GameObject loseScreen;
    [SerializeField] GameObject buttons;
    [SerializeField] Slider mySlider;
    [SerializeField] GameObject starDisplay;

    private void Start()
    {       
        loseScreen.SetActive(false);
        health = PlayerPrefsController.GetDifficulty();
        UpdateHealthScore();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Attacker")
        {
            health--;
            UpdateHealthScore();
            Destroy(collision.gameObject);
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
