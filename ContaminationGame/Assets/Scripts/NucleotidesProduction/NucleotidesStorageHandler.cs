using System;
using StateMachine2;
using UnityEngine;

namespace NucleotidesProduction
{
    public class NucleotidesStorageHandler : MonoBehaviour
    {
        [SerializeField] private NucleotideTileStorage nucleotidesTileStorage;
        [SerializeField] private AreaState areaState;
        [SerializeField] private int maxStorage;

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
            nucleotidesTileStorage.MaxStorage = maxStorage;
        }
    }
}