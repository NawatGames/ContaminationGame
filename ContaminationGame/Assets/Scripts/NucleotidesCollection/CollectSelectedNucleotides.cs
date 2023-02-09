using System;
using NucleotidesProduction;
using StateMachine2;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class CollectSelectedNucleotides : MonoBehaviour
    {
        [SerializeField] private TerrainSelectionManager terrainSelectionManager;
        [SerializeField] private PlayerInput playerInput;
        private TerrainData currentTerrainData;
        public UnityEvent SuccessfulNucleotidesTransferEvent;
        public UnityEvent FailedNucleotidesTransferEvent;

        private void OnCollectNucleotidesRequest()
        {
            if (currentTerrainData is null) return; // GuardClause

            if (currentTerrainData.VerifierStorageCondition.IsActive)
            {
                currentTerrainData.TileNucleotidesTransferer.TransferNucleotides();
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
        }

        private void OnDisable()
        {
            terrainSelectionManager.SelectionChangedEvent.RemoveListener(OnSelectionChanged);
            playerInput.CollectNucleotidesRequestEvent.RemoveListener(OnCollectNucleotidesRequest);
        }

        private void OnSelectionChanged()
        {
            currentTerrainData = terrainSelectionManager.TerrainData;
        }
        
        
    }
}


