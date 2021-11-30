using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM : MonoBehaviour
{
    public FSMStateType startState = FSMStateType.None; // none state = idle state
    private IFSMStates[] statePool;
    private IFSMStates currentState;
    private readonly IFSMStates EmptyAction = new NoneState();

    private void Awake()
    {
        statePool = GetComponents<IFSMStates>();

        int randIntX = Random.Range(-90, 90);
        int randIntY = Random.Range(-90, 90);
        gameObject.transform.position = new Vector3(randIntX, 0, randIntY);

    }

    private void Start()
    {
        currentState = EmptyAction;
        TransitionToState(startState);
    }



    private void Update()
    {
        currentState.DoAction();
        FSMStateType transitionState = currentState.ShouldTransitionToState();
        if (transitionState != currentState.StateName)
        {
            TransitionToState(transitionState);
        }
    }

    private void TransitionToState(FSMStateType state)
    {
        currentState.OnExit();
        currentState = GetState(state);
        currentState.OnEnter();

        Debug.Log("Transition to: " + currentState.StateName);
    }
    IFSMStates GetState(FSMStateType stateName)
    {
        foreach (var state in statePool)
        {
            if (state.StateName == stateName)
            {
                return state;
            }
        }

        return EmptyAction;
    }
}
