using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject [] Vehicle, Colours;

    

    private int CarImport = GlobalCar.CarType;
    void Start()
    {
        switch (CarImport)
        {
            case 0:
                Vehicle[0].SetActive(true);
                Colours[0].SetActive(true);
                break;
            case 1:
                Vehicle[0].SetActive(true);
                Colours[1].SetActive(true);
                break;
            case 2:
                Vehicle[1].SetActive(true);
                break;
        }
    }


}
