using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay, SecondDisplay, MilliDisplay, LapTimeBox, LapCounter, RaceFinish;

    public int Laps;

    public static float RawTime;



    private void Update()
    {
        if(Laps == 1)
        {
            RaceFinish.SetActive(true);
        }
    }
    private void OnTriggerEnter()
    {
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if(LapTimeManager.RawTime < RawTime || RawTime == 0)
        {
            if (LapTimeManager.MinuteCount <= 9)
            {
                MinuteDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.MinuteCount + ":";
            }
            else
            {
                MinuteDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.MinuteCount + ":";
            }

            if (LapTimeManager.SecondCount <= 9)
            {
                SecondDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.SecondCount + ".";
            }
            else
            {
                SecondDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.SecondCount + ".";
            }

            MilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.MilliDisplay;

            PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
            PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
            PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MilliCount);
            PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);

        }



        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;
        LapTimeManager.RawTime = 0;
        Laps++;

        LapCounter.GetComponent<TextMeshProUGUI>().text = "" + Laps;
        

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }
}
