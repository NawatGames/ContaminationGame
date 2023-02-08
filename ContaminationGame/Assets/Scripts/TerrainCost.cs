using UnityEngine;
using UnityEngine.Events;
public class TerrainCost : MonoBehaviour
    {
        [SerializeField] private int nucleotidesCost;
        public UnityEvent TerrainDataChangedEvent;

        public int Nucleotides
        {
            get => nucleotidesCost;
            set
            {
                nucleotidesCost = value;
                TerrainDataChangedEvent.Invoke();
            }
        }
    }
