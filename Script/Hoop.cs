using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Hoop : MonoBehaviour
{
    Vector3 fark;
    public Transform cy;
  
   
    
    private void OnMouseDown()
    {
        //ilk týkladýgýmýz an calýsýr
        fark = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position); //fark fareyle posizyon arasý z degeri

    }

    private void OnMouseDrag() //tasýma
    {
        transform.position =Camera.main.ScreenToWorldPoint( Input.mousePosition-fark);

        
    }
    private void OnMouseUp()
    {
        //transform.position = cy.position;
        transform.DOMove(cy.transform.position, 0.2f);
    }

}
