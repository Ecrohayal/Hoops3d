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
        //ilk t�klad�g�m�z an cal�s�r
        fark = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position); //fark fareyle posizyon aras� z degeri

    }

    private void OnMouseDrag() //tas�ma
    {
        transform.position =Camera.main.ScreenToWorldPoint( Input.mousePosition-fark);

        
    }
    private void OnMouseUp()
    {
        //transform.position = cy.position;
        transform.DOMove(cy.transform.position, 0.2f);
    }

}
