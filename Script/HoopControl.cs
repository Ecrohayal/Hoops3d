using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopControl : MonoBehaviour
{
    Vector3 offset;
    public string destinationTag = "Player";

    public Transform cy;

    public AudioSource audio;
    public AudioClip hoop;
  
    private void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        audio.PlayOneShot(hoop);
    }
    private void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
       


    }
   /* private void OnMouseUp()
    {
        var rayOrijin = Camera.main.transform.position;
        var rayDiretion = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitInfo;

       if(Physics.Raycast(rayOrijin,rayDiretion,out hitInfo))
        {
           if(hitInfo.transform.tag==destinationTag)
            {
                transform.position = hitInfo.transform.position;

              


            }
          
        } 
    }*/

    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
       
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }

    private void OnMouseUp()
    {
        transform.DOMove(cy.transform.position, 0.2f);
       

    }

   
}
