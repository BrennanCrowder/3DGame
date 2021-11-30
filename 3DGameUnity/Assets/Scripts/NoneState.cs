using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoneState : MonoBehaviour, IFSMStates
{
    private bool toFollow;

    public FSMStateType StateName { get { return FSMStateType.None; } }
    public void OnEnter()
    {
        
    }
    public void OnExit()
    {
        
    }
    public void DoAction()
    {
        // Do Nothing
    }
    public FSMStateType ShouldTransitionToState()
    {
        if (GetComponentInChildren<KeyTriggerScript>().follow)
        {
            return FSMStateType.Follow;
        }

        return FSMStateType.None;
    }

}