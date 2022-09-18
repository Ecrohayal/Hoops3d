using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CylinderController : MonoBehaviour
{
    public Transform target,target2;
    NavMeshAgent navMesh;
    public bool degdi = false;
    
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        if(degdi==false)
        {
            navMesh.SetDestination(target.transform.position);
          
        }

        else
        {
            navMesh.SetDestination(target2.transform.position);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="target")
        {
            degdi = true;
        }

       
    }

}
