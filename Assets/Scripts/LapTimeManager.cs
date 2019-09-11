﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LapTimeManager : MonoBehaviour
{
    public static int MinuteCount, SecondCount;
    public static float MilliCount, RawTime;
    public static string MilliDisplay;

    public GameObject MinuteBox, SecondBox, MilliBox;

    // Update is called once per frame
    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        MilliDisplay = MilliCount.ToString("F0");
        MilliBox.GetComponent<TextMeshProUGUI>().text = "" + MilliDisplay;

        if(MilliCount >= 9)
        {
            MilliCount = 0;
            SecondCount++;
        }

        if(SecondCount <= 9)
        {
            SecondBox.GetComponent<TextMeshProUGUI>().text = "0" + SecondCount + ".";
        }
        else
        {
            SecondBox.GetComponent<TextMeshProUGUI>().text = "" + SecondCount + ".";
        }

        if(SecondCount >= 60)
        {
            MinuteCount++;
            SecondCount = 0;
        }

        if(MinuteCount <= 9)
        {
            MinuteBox.GetComponent<TextMeshProUGUI>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<TextMeshProUGUI>().text = "" + MinuteCount + ":";
        }
    }
}
