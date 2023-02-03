using System;
using StateMachine2;
using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;

namespace NucleotidesProduction
{
    /// <summary>
    /// Avalia a condicao para transferir os nucleotideos para o player
    /// Se nao for o maximo, ele nao consegue pegar
    /// </summary>
    public class VerifierStorageCondition : MonoBehaviour
    {
        [SerializeField] private NucleotideTileStorage nucleotidesTileStorage;
        [SerializeField] private AreaStateMachine areaStateMachine;
        [SerializeField] private AreaState initialAreaState;
        [SerializeField] private bool isActive;
        public UnityEvent TransfererConditionChangedEvent;
        public bool IsActive => isActive;

        private void Start()
        {
            OnCurrentStorageChanged();
        }

        private void OnEnable()
        {
            nucleotidesTileStorage.currentStorageChangedEvent.AddListener(OnCurrentStorageChanged);
        }
        
        private void OnDisable()
        {
            nucleotidesTileStorage.currentStorageChangedEvent.RemoveListener(OnCurrentStorageChanged);
        }
        private void OnCurrentStorageChanged()
        {
            var wasActive = isActive;
            isActive = nucleotidesTileStorage.CurrentStorage == nucleotidesTileStorage.MaxStorage; //&& areaStateMachine.CurrentState != initialAreaState;
            if (isActive != wasActive)
            {
                TransfererConditionChangedEvent.Invoke();
            }
        }
    }
}