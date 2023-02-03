using UnityEngine;
using UnityEngine.Events;

namespace StateMachine2
{
    public class AreaStateMachine : MonoBehaviour
    {
        [field: SerializeField] public AreaState CurrentState { get; private set; }
        public UnityEvent ChangedStateEvent;
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
            ChangedStateEvent.Invoke();
        }

        public void SwitchToNextState()
        {
            SwitchState(CurrentState.nextState);
        }
    }
}