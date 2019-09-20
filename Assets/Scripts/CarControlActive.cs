using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    public GameObject[] Cars;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < Cars.Length; i++)
        Cars[i].GetComponent<CarController>().enabled = true;

    }


}
