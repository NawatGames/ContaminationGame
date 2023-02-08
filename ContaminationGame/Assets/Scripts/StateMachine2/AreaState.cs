using UnityEngine;
using UnityEngine.Events;
using UnityEngine.PlayerLoop;

namespace StateMachine2
{
    public class AreaState : MonoBehaviour
    {
        public UnityEvent EnterStateEvent;
        public UnityEvent UpdateStateEvent;
        public UnityEvent LeaveStateEvent;
        public AreaState nextState;
        public string areaStateName;
        
        
        public void EnterState(AreaStateMachine area)
        {
            EnterStateEvent.Invoke();
        }

        public void UpdateState(AreaStateMachine area)
        {
            UpdateStateEvent.Invoke();
        }

        public void LeaveState(AreaStateMachine area)
        {
            LeaveStateEvent.Invoke();
        }

    }
}