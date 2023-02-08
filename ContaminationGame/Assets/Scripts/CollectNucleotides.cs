using System;
using NucleotidesProduction;
using StateMachine2;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class CollectNucleotides : MonoBehaviour
    {
        [SerializeField] private TerrainSelectionManager terrainSelectionManager;
        [SerializeField] private PlayerInput playerInput;
        [SerializeField] private CollectNucleotidesOnLastAreaHandler collectNucleotidesOnLastAreaHandler;
        private TerrainData terrainData;
        public UnityEvent SuccessfulNucleotidesTransferEvent;
        public UnityEvent FailedNucleotidesTransferEvent;

        private void OnCollectNucleotidesRequest()
        {
            if (terrainData is null) return; // GuardClause
            
            if (terrainData.VerifierStorageCondition.IsActive)
            {
                terrainData.TileNucleotidesTransferer.TransferNucleotides();
                SuccessfulNucleotidesTransferEvent.Invoke();
            }
            else
            {
                FailedNucleotidesTransferEvent.Invoke();
            }
        }
        
        private void OnEnable()
        {
            terrainSelectionManager.SelectionChangedEvent.AddListener(OnSelectionChanged);
            playerInput.CollectNucleotidesRequestEvent.AddListener(OnCollectNucleotidesRequest);
            collectNucleotidesOnLastAreaHandler.CollectNucleotidesAutomaticallyEvent.AddListener(OnCollectNucleotidesAutomatically);
            
        }

        private void OnDisable()
        {
            terrainSelectionManager.SelectionChangedEvent.RemoveListener(OnSelectionChanged);
            playerInput.CollectNucleotidesRequestEvent.RemoveListener(OnCollectNucleotidesRequest);
            collectNucleotidesOnLastAreaHandler.CollectNucleotidesAutomaticallyEvent.RemoveListener(OnCollectNucleotidesAutomatically);
        }

        private void OnSelectionChanged()
        {
            terrainData = terrainSelectionManager.TerrainData;
        }
        private void OnCollectNucleotidesAutomatically()
        {
            OnCollectNucleotidesRequest();
        }
        
    }
}