using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandler : MonoBehaviour
{

    public Text timerText;
    public Text lapsText;

    private float currentTime;
    void Start()
    {
        
    }

    
    void Update()
    {
        // TimerText.text = Time.time.ToString();
        currentTime = Mathf.Round(Time.time);
        timerText.text = currentTime.ToString();
        lapsText.text = Mathf.Round((currentTime - 4)/10).ToString();
    }
}
