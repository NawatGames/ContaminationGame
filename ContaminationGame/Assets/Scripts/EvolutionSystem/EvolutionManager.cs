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
            var value = terrainData.Nucleotides;
            if (playerInfo.nucleotides >= value)
            {
                var areaStateController = terrainData.GetComponentInChildren<AreaStateController>();
                if (areaStateController.CurrentState == areaStateController.FinalState)
                {
                    
                }
            }
            else
            {
                FailedEvolutionEvent.Invoke();
            }
            
        }
    }
}