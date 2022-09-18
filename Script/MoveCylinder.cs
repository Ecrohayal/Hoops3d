using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCylinder : MonoBehaviour
{
    public float running;
    private float current;
   
   
    void Start()
    {
        current = running;
        
    }

   
    void Update()
    {
        Vector3 newPos = new Vector3(transform.position.x + current*Time.deltaTime, transform.position.y, transform.position.z);
        transform.position = newPos;
    }

}
