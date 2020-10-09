using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetBehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Vector3 new_location = new Vector3();


        new_location.x = Random.Range(-30f, -90f);
        new_location.z = Random.Range(-15f, 60f);
        new_location.y = 0;
        transform.position = new_location;
        agent.SetDestination(transform.position);

    }
}
