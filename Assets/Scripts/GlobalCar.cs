using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{

    public static int CarType;
    public GameObject TrackWindow;

    public void RedCar()
    {
        CarType = 0;
    }

    public void BlueCar()
    {
        CarType = 1;
    }
}
