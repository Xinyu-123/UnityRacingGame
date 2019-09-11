using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    public GameObject Countdown, LapTimer, CarControls;
    public AudioSource GetReady, LevelMusic;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        Countdown.GetComponent<TextMeshProUGUI>().text = "3";
        GetReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<TextMeshProUGUI>().text = "2";
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<TextMeshProUGUI>().text = "1";
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<TextMeshProUGUI>().text = "GO!";
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);

        LapTimer.SetActive(true);
        CarControls.SetActive(true);
        LevelMusic.Play();

    }

}
