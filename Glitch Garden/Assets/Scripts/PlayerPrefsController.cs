using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string VOLUME_KEY = "volume";
    const string DIFFICULTY_KEY = "difficulty";

    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    public static void SetVolume(float volume)
    {
        if (volume <= MAX_VOLUME && volume >= MIN_VOLUME)
        {
            PlayerPrefs.SetFloat(VOLUME_KEY, volume);
            Debug.Log("Volume set to " + volume);
        }
        else
        {
            Debug.LogError("Volume out of range");
        }
    }

    public static float GetVolume()
    {
        return PlayerPrefs.GetFloat(VOLUME_KEY);
    }

    public static void SetDifficulty(int difficulty)
    {
        PlayerPrefs.SetInt(DIFFICULTY_KEY, difficulty);
        Debug.Log("Difficulty set to " + difficulty);
    }

    public static int GetDifficulty()
    {
        return PlayerPrefs.GetInt(DIFFICULTY_KEY);
    }
}
