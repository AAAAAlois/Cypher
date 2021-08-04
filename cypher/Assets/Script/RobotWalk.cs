using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RobotWalk : MonoBehaviour
{
    public Transform myPos1;
    public Transform myPos2;

    private NavMeshAgent robotAgen1;




    // Start is called before the first frame update
    void Start()
    {
        robotAgen1 = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "a1")
            robotAgen1.SetDestination(myPos2.position);

        if (other.tag == "a2")
            robotAgen1.SetDestination(myPos1.position);
    }
}
