using UnityEngine;
using UnityEngine.Events;
using UnityEngine.PlayerLoop;

namespace StateMachine2
{
    public class AreaState : MonoBehaviour
    {
        public UnityEvent EnterStateEvent;
        public UnityEvent UpdateStateEvent;
        public AreaState nextState;
        public void EnterState(AreaStateMachine area)
        {
            EnterStateEvent.Invoke();
        }

        public void UpdateState(AreaStateMachine area)
        {
            UpdateStateEvent.Invoke();
        }

    }
}