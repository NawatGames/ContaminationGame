 using System;
using EvolutionSystem;
using StateMachine2;
using UnityEngine;
using UnityEngine.Events;
 using UnityEngine.Serialization;

 namespace EvolutionSystem
{
    public class EvolutionManager : MonoBehaviour
    {
        [SerializeField] private PlayerInfo playerInfo;
        [SerializeField] private TerrainSelectionManager terrainSelectionManager;
        [FormerlySerializedAs("SuccessfullEvolutionEvent")] public UnityEvent SuccessfulEvolutionEvent;
        public UnityEvent FailedEvolutionEvent;


        public void RequestEvolution(TerrainData terrainData)
        {
            if (terrainData is null)
            {
                FailedEvolutionEvent.Invoke();
                return;
            }
            
            if (!terrainData.VerifierStorageCondition.IsActive)
            {
                FailedEvolutionEvent.Invoke();
                return;
            }
            var value = terrainData.TerrainCost.Nucleotides;
            if (playerInfo.PlayerNucleotides >= value)
            {
                var areaStateMachine = terrainData.GetComponentInChildren<AreaStateMachine>();
                if (areaStateMachine.CurrentState.nextState is null)
                {
                    FailedEvolutionEvent.Invoke();
                }
                else
                {
                    areaStateMachine.SwitchToNextState();
                    playerInfo.RemovePlayerNucleotides(value);
                    SuccessfulEvolutionEvent.Invoke();
                }
            }
            else
            {
                FailedEvolutionEvent.Invoke();
            }
        }
    }
}

