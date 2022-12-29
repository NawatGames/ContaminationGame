using System;
using UnityEngine;

namespace StateMachine2
{
    public class StateAnimatorHandler : MonoBehaviour
    {
        [SerializeField] private GameObject animationGameObject;
        [SerializeField] private AreaState areaState;

        private void Awake()
        {
            animationGameObject.SetActive(false);
        }

        private void OnEnable()
        {
            areaState.EnterStateEvent.AddListener(OnEnterState);
            areaState.LeaveStateEvent.AddListener(OnLeaveState);
        }
        
        private void OnDisable()
        {
            areaState.EnterStateEvent.RemoveListener(OnEnterState);
            areaState.LeaveStateEvent.RemoveListener(OnLeaveState);
        }


        private void OnLeaveState()
        {
            animationGameObject.SetActive(false);
        }

        private void OnEnterState()
        {
            animationGameObject.SetActive(true);
        }
    }
}