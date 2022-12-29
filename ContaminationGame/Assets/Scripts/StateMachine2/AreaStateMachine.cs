using UnityEngine;

namespace StateMachine2
{
    public class AreaStateMachine : MonoBehaviour
    {
        [field: SerializeField] public AreaState CurrentState { get; private set; }
        void Start()
        {
            CurrentState.EnterState(this);
        }

        // Update is called once per frame
        void Update()
        {
            CurrentState.UpdateState(this);
        }

        public void SwitchState(AreaState state)
        {
            if (CurrentState != null)
            {
                CurrentState.LeaveState(this);
            }
            CurrentState = state;
            state.EnterState(this);
        }

        public void SwitchToNextState()
        {
            SwitchState(CurrentState.nextState); 
        }
    }
}