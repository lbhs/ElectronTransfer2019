﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public Text ButtonText;

    void Start()
    {
        Time.timeScale = 0;
        ButtonText.text = "Play";
    }
    public void ToggleTime()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 0.25f;
            ButtonText.text = "Pause";
        }
        else
        {
            Time.timeScale = 0;
            ButtonText.text = "Play";
        }
    }
    // Text speed;

    // public void updateTimeScale(float scale)
    // {
    //     GameObject.Find("speedText").GetComponent<Text>().text = "Simulation: " + (scale / 1).ToString() + "x";
    //     if (scale < 0)
    //     {
    //         if (GameObject.Find("GameObject").GetComponent<TimeBody>().frame == -1)
    //         {
    //             Time.timeScale = 0f;
    //             GetComponent<UnityEngine.UI.Slider>().value = 0;
    //         }
    //         else
    //         {
    //             GameObject.Find("GameObject").GetComponent<forces>().startRewind();
    //             Time.timeScale = Math.Abs(scale / 4);
    //             GetComponent<UnityEngine.UI.Slider>().value = scale;
    //         }
    //     }
    //     else
    //     {
    //         Time.timeScale = scale / 4;
    //         GetComponent<UnityEngine.UI.Slider>().value = scale;
    //         GameObject.Find("GameObject").GetComponent<forces>().stopRewind();
    //     }
    // }

}
