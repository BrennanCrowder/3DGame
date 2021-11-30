using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockState : MonoBehaviour, IFSMStates
{
    public static bool unlock;
    public static string unlockDir;
    public FSMStateType StateName { get { return FSMStateType.Unlock; } }
    public void OnEnter()
    {
        // Set Position
    }
    public void OnExit()
    {
        // Will Never Exit
    }
    public void DoAction()
    {
        if (unlock)
        {
            UnlockDoor(unlockDir);
            unlock = false;
            unlockDir = null;
        }
    }

    public void UnlockDoor(string Direction)
    {
        EndDoorScript.unlockDir = Direction;
    }

    public FSMStateType ShouldTransitionToState()
    {
        return FSMStateType.Unlock;
    }
}

