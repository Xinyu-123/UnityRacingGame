using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01Track : MonoBehaviour
{
    public GameObject TheMarker, Mark01, Mark02, Mark03, Mark04, Mark05, Mark06, Mark07, Mark08;
    public int MarkTracker;


    // Update is called once per frame
    void Update()
    {
        switch (MarkTracker)
        {
            case 0:
                TheMarker.transform.position = Mark01.transform.position;
                break;
            case 1:
                TheMarker.transform.position = Mark02.transform.position;
                break;
            case 2:
                TheMarker.transform.position = Mark03.transform.position;
                break;
            case 3:
                TheMarker.transform.position = Mark04.transform.position;
                break;
            case 4:
                TheMarker.transform.position = Mark05.transform.position;
                break;
            case 5:
                TheMarker.transform.position = Mark06.transform.position;
                break;
            case 6:
                TheMarker.transform.position = Mark07.transform.position;
                break;
            case 7:
                TheMarker.transform.position = Mark08.transform.position;
                break;
        }

    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Dreamcar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker++;
            if (MarkTracker == 8)
                MarkTracker = 0;
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
