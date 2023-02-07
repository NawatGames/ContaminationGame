using System;
using NucleotidesProduction;
using StateMachine2;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class CollectNucleotidesOnLastAreaHandler : MonoBehaviour
    {
        [SerializeField] private AreaState lastArea;
        [SerializeField] private AreaStateMachine areaStateMachine;
        [SerializeField] private TerrainData terrainData;
        public UnityEvent CollectNucleotidesAutomaticallyEvent;
        
        
        //ver se ele esta na ultima area
        //se estiver, requisitar para comprar a area

        private void OnEnable()
        {
            terrainData.VerifierStorageCondition.TransfererConditionChangedEvent.AddListener(OnTransferConditionChanged);
        }

        private void OnDisable()
        {
            terrainData.VerifierStorageCondition.TransfererConditionChangedEvent.RemoveListener(OnTransferConditionChanged);
        }

        private void OnTransferConditionChanged()
        {
            if (terrainData is null) return;

            if (terrainData.VerifierStorageCondition.IsActive)
            {
                CollectNucleotidesAutomaticallyEvent.Invoke();
            }
        }
    }
}