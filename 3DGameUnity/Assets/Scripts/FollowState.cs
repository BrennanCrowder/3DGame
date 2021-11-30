using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class FollowState : MonoBehaviour, IFSMStates
{
    private GameObject player;
    private NavMeshAgent keyAgent;
    public static bool unlockDoor;


    public FSMStateType StateName { get { return FSMStateType.Follow; } }
    public void OnEnter()
    {
        Debug.Log("Following");
        UnlockTrigger.hasKey = true;
        keyAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void OnExit()
    {
        keyAgent.isStopped = true;
        // End Start Animation
    }
    public void DoAction()
    {

        keyAgent.SetDestination(player.transform.position);
    }
    public FSMStateType ShouldTransitionToState()
    {
       // Can Transition to Unlock
        if (unlockDoor)
        {
            return FSMStateType.Unlock;
        }

        return FSMStateType.Follow;
    }
}
