using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject[] Cameras;
    int CamMode;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Viewmode"))
        {
            if (CamMode == 2)
                CamMode = 0;
            else
            {
                CamMode++;
            }

            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);

        switch (CamMode)
        {
            case 0:
                Cameras[0].SetActive(true);
                Cameras[2].SetActive(false);
                break;
            case 1:
                Cameras[1].SetActive(true);
                Cameras[0].SetActive(false);
                break;
            case 2:
                Cameras[2].SetActive(true);
                Cameras[1].SetActive(false);
                break;
        }

    }
}
