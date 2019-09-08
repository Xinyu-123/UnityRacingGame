using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay, SecondDisplay, MilliDisplay, LapTimeBox;

    private void OnTriggerEnter()
    {

        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.MinuteCount + ":";
        }
        else
        {
            MinuteDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.MinuteCount + ":";
        }

        if(LapTimeManager.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.SecondCount + ".";
        }

        MilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.MilliDisplay;

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }
}
