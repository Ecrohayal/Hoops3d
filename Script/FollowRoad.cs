using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class FollowRoad : MonoBehaviour
{
    public Transform target;
    NavMeshAgent navMesh;
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

  
    void Update()
    {
        navMesh.SetDestination(target.transform.position);
    }
}
