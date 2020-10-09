using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MonsterMotion : MonoBehaviour
{

    public GameObject target;
    NavMeshAgent theAgent;

    // Start is called before the first frame update
    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
        theAgent.SetDestination(target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animation>().Play("Walk");

    }
}
