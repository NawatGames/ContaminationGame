using System;
using EvolutionSystem;
using StateMachine2;
using UnityEngine;
using UnityEngine.Events;

namespace EvolutionSystem
{
    public class EvolutionManager : MonoBehaviour
    {
        [SerializeField] private PlayerInfo playerInfo;
        [SerializeField] private TerrainSelectionManager terrainSelectionManager;
        public UnityEvent SuccessfullEvolutionEvent;
        public UnityEvent FailedEvolutionEvent;


        public void RequestEvolution(TerrainData terrainData)
        {
            if (terrainData is null)
            {
                FailedEvolutionEvent.Invoke();
                return;
            }
            var value = terrainData.Nucleotides;
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
                    SuccessfullEvolutionEvent.Invoke();
                }
            }
            else
            {
                FailedEvolutionEvent.Invoke();
            }
        }
    }
}