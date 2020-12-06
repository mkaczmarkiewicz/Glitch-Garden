using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Base : MonoBehaviour
{
    int health = 5;

    [SerializeField] Text textHealth;

    private void Start()
    {
        UpdateHealthScore();
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
            SceneManager.LoadScene(0);
        }
    }

    private void UpdateHealthScore()
    {
        textHealth.text = health.ToString();
    }
}
