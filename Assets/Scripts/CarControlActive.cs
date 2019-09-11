﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    public GameObject Car, Dreamcar01;
    
    // Start is called before the first frame update
    void Start()
    {
        Car.GetComponent<CarController>().enabled = true;
        Dreamcar01.GetComponent<CarController>().enabled = true;

    }


}
