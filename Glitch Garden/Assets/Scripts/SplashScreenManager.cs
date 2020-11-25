using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadingScreen());
    }

    public IEnumerator LoadingScreen()
    {
        AudioSource myAudioSource = GetComponent<AudioSource>();
        myAudioSource.PlayOneShot(myAudioSource.clip);

        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene("Start Scene");
    }
}
