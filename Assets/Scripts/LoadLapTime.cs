using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadLapTime : MonoBehaviour
{
    public int MinCount, SecCount;
    public float MilliCount;
    public string MilliStr;

    public GameObject MinDisplay, SecDisplay, MilliDisplay;
    void Start()
    {
        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilliCount = PlayerPrefs.GetFloat("MilliSave");

        if (MinCount <= 9)
        {
            MinDisplay.GetComponent<TextMeshProUGUI>().text = "0" + MinCount + ":";
        }
        else
        {
            MinDisplay.GetComponent<TextMeshProUGUI>().text = "" + MinCount + ":";
        }

        if (SecCount <= 9)
        {
            SecDisplay.GetComponent<TextMeshProUGUI>().text = "0" + SecCount + ".";
        }
        else
        {
            SecDisplay.GetComponent<TextMeshProUGUI>().text = "" + SecCount + ".";
        }

        MilliStr = MilliCount.ToString("F0");
        MilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + MilliStr;

    }


}
