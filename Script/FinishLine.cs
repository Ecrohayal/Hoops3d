using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject endPanel;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="OrangeCylinder" || other.tag=="BlueCylinder"||other.tag=="PinkCylinder"||other.tag=="GreenCylinder"||other.tag=="RedCylinder"||other.tag=="Untagged")
        {
            Destroy(other.gameObject, 0.1f);
            endPanel.SetActive(true);
        }
    }
}
