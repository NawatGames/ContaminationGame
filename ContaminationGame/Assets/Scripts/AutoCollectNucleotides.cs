using NucleotidesProduction;
using UnityEngine;

namespace DefaultNamespace
{
    public class AutoCollectNucleotides : MonoBehaviour
    {
        [SerializeField] private CollectNucleotidesOnLastAreaHandler collectNucleotidesOnLastAreaHandler;
        [SerializeField] private TileNucleotidesTransferer tileNucleotidesTransferer;

        private void OnEnable()
        {
            collectNucleotidesOnLastAreaHandler.CollectNucleotidesAutomaticallyEvent.AddListener(OnCollectNucleotidesAutomatically);
        }

        private void OnDisable()
        {
            collectNucleotidesOnLastAreaHandler.CollectNucleotidesAutomaticallyEvent.RemoveListener(OnCollectNucleotidesAutomatically);
        }

        private void OnCollectNucleotidesAutomatically()
        {
            tileNucleotidesTransferer.TransferNucleotides();
        }
    }
}