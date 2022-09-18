using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanabiliHoop : MonoBehaviour
{

    bool toplandiMi;
    float index;
    
    void Start()
    {
        toplandiMi = false;
    }


    private void FixedUpdate()
    {
        if (toplandiMi == true)
        {

            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index,0);
                
            }


        }



    }

    public bool GetToplandiMi()
    {
        return toplandiMi;
    }

    public void ToplandiYap()
    {
        toplandiMi = true;
    }

    public void indexAyarla(float index)
    {
        this.index = index;

    }
 

   
}


