using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject MyCar, FinishCam, ViewModes;
    public AudioSource LevelMusic, FinishMusic;

    public GameObject MinuteDisplay, SecondDisplay, MilliDisplay, LapTimes;

    public int Laps;

    public float RawTime;

    private void OnTriggerEnter(Collider other)
    {
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if (LapTimeManager.RawTime < RawTime || RawTime == 0)
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


        this.GetComponent<BoxCollider>().enabled = false;
        MyCar.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        MyCar.GetComponent<CarController>().enabled = false;
        MyCar.GetComponent<CarUserControl>().enabled = false;
        MyCar.SetActive(true);
        FinishCam.SetActive(true);
        ViewModes.SetActive(false);
        LevelMusic.Stop();
        FinishMusic.Play();
        LapTimes.SetActive(false);
    }
}
