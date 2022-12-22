using UnityEngine;

namespace StateMachine2
{
    public class AreaStateController : MonoBehaviour
    {
        [field: SerializeField] public AreaBaseState CurrentState { get; private set; }
        [field: SerializeField] public AreaBaseState FinalState { get; }

        void Start()
        {
            CurrentState.EnterState(this);
        }

        // Update is called once per frame
        void Update()
        {
            CurrentState.UpdateState(this);
        }

        public void SwitchState(AreaBaseState state)
        {
            CurrentState = state;
            state.EnterState(this);
        }
    }
}