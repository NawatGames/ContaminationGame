using UnityEngine;
using UnityEngine.Events;
using UnityEngine.PlayerLoop;

namespace StateMachine2
{
    public enum AreaState
    {
        Healthy, Contaminated, Dominated, ViralCradle
    }
    public class AreaBaseState : MonoBehaviour
    {
        public UnityEvent EnterStateEvent;
        public UnityEvent UpdateStateEvent;
        [SerializeField] private AreaState state;
        public void EnterState(AreaStateController area)
        {
            EnterStateEvent.Invoke();
        }

        public void UpdateState(AreaStateController area)
        {
            UpdateStateEvent.Invoke();
        }

    }
}