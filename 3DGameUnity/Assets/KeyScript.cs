using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using StarterAssets;
public class KeyScript : MonoBehaviour
{

    public GameObject player;
    public NavMeshAgent keyAgent;
    private void Awake()
    {
        keyAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        
    }
    private void Update()
    {
        keyAgent.SetDestination(player.transform.position);
    }
}
