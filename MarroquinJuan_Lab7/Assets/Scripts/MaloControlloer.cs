using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MaloControlloer : MonoBehaviour
{
    public NavMeshAgent agent;
    private List<GameObject> listwp;
    public GameObject waypoints;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        listwp = new List<GameObject>();
        
        for(int i = 0;i<waypoints.transform.childCount; i++)
        {
            listwp.Add(waypoints.transform.GetChild(i).gameObject);
        }

        agent.SetDestination(listwp[Random.Range(0,listwp.Count-1)].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance<2f)
        {
            agent.SetDestination(listwp[Random.Range(0,listwp.Count-1)].transform.position);
        }
    }
}
