using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] float levelTime = 10;

    Slider mySlider;

    bool timerFinished;

    private void Start()
    {
        mySlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        mySlider.value = Time.timeSinceLevelLoad / levelTime;

        timerFinished = (Time.timeSinceLevelLoad >= levelTime);       
    }

    public bool TimerFinished()
    {
        return timerFinished;
    }
}
