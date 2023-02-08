using StateMachine2;
using UnityEngine;

namespace NucleotidesProduction
{
    public class NucleotidesCostHandler : MonoBehaviour
    {
        [SerializeField] private TerrainData terrainData;
        [SerializeField] private AreaState areaState;
        [SerializeField] private int nucleotidesCost;

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
            terrainData.TerrainCost.Nucleotides = nucleotidesCost;
        }
    }
}