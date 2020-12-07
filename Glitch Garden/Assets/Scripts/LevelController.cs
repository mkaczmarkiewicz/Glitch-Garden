using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject[] spawners;
    [SerializeField] GameTimer myGameTimer;
    [SerializeField] GameObject winScreen;
    [SerializeField] GameObject loseScreen;

    private void Start()
    {
        winScreen.SetActive(false);
    }
    void Update()
    {
        if (myGameTimer.TimerFinished())
        {
            if (!AttackersPresent())
            {
                if (loseScreen.active == false)
                    StartCoroutine(ShowWinScreen());
            }
        }
    }

    private bool AttackersPresent() 
    {
        bool attackersPresent = false;

        foreach (GameObject spawner in spawners)
        {
            if (spawner.transform.childCount > 0)
                attackersPresent = true;
        }

        return attackersPresent;
    }

    private IEnumerator ShowWinScreen()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);
        winScreen.SetActive(true);        
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(1);
    }
}
