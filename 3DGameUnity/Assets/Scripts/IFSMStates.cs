public interface IFSMStates
{
    FSMStateType StateName { get; }
    void OnEnter();
    void OnExit();
    void DoAction();
    FSMStateType ShouldTransitionToState();
}
