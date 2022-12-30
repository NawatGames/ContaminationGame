using System;
using StateMachine2;
using UnityEngine;

namespace NucleotidesProduction
{
    public class NucleotidesGeneratorHandler : MonoBehaviour
    {
        [SerializeField] private NucleotidesGenerator nucleotidesGenerator; 
        [SerializeField] private AreaState areaState;
        [SerializeField] private int netFee;
        [SerializeField] private float delayTime;

        private void OnEnable()
        {
            areaState.EnterStateEvent.AddListener(OnEnterState);
        }

        private void OnDisable()
        {
            areaState.EnterStateEvent.RemoveListener(OnEnterState);
        }

        private void OnEnterState()
        {
            nucleotidesGenerator.NetFee = netFee;
            nucleotidesGenerator.DelayTime = delayTime;
        }
    }
}