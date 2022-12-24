using UnityEngine;

namespace EvolutionSystem
{
    public class EvolutionRequester : MonoBehaviour
    {

        private TerrainData _terrainData;
        [SerializeField] private EvolutionManager evolutionManager;
        [SerializeField] private PlayerInput playerInput;
        [SerializeField] private TerrainSelectionManager terrainSelectionManager;

        private void OnEnable()
        {
            playerInput.evolutionRequestEvent.AddListener(OnEvolutionRequest);
            terrainSelectionManager.SelectionChangedEvent.AddListener(OnSelectionChanged);
        }


        private void OnDisable()
        {
            playerInput.evolutionRequestEvent.RemoveListener(OnEvolutionRequest);
            terrainSelectionManager.SelectionChangedEvent.RemoveListener(OnSelectionChanged);
        }

        private void OnSelectionChanged()
        {
            _terrainData = terrainSelectionManager.TerrainData;
        }

        private void OnEvolutionRequest()
        {
            evolutionManager.RequestEvolution(_terrainData);
        }
    }
}