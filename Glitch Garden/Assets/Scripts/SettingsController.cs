using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider difficultySlider;

    MusicPlayer myMusicPlayer;

    private void Start()
    {
        myMusicPlayer = FindObjectOfType<MusicPlayer>();

        volumeSlider.value = PlayerPrefsController.GetVolume();
        difficultySlider.value = PlayerPrefsController.GetDifficulty();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void DefaultSettings()
    {
        volumeSlider.value = 1;
        difficultySlider.value = 3;
    }

    private void Update()
    {
        if(myMusicPlayer)
        {
            myMusicPlayer.ChangeMusicVolume(volumeSlider.value);
            PlayerPrefsController.SetVolume(volumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No music player lol");
        }

        int difficultyAsInt = (int) difficultySlider.value;

        PlayerPrefsController.SetDifficulty(difficultyAsInt);
    }
}
