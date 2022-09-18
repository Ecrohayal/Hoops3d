using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLight : MonoBehaviour
{
    public Animator anim;
   
   
    private void FixedUpdate()
    {
        
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="BlueCylinder"||other.tag=="OrangeCylinder"||other.tag=="PinkCylinder"||other.tag=="GreenCylinder"||other.tag=="Toplandi")
        {
            anim.SetTrigger("son");
        }
       

    }
}
