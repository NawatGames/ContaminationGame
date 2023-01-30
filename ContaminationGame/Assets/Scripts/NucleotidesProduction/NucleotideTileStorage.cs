using UnityEngine;
using UnityEngine.Events;

namespace NucleotidesProduction
{
    public class NucleotideTileStorage : MonoBehaviour
    {
        [SerializeField] private int currentStorage;
        [SerializeField] private int maxStorage;
        public UnityEvent currentStorageChangedEvent;
        public int MaxStorage
        {
            get => maxStorage;
            set => maxStorage = value;
        }
        
        public int CurrentStorage
        {
            get => currentStorage;
            set
            {
                currentStorage = Mathf.Clamp(value, 0, maxStorage);
                currentStorageChangedEvent.Invoke();
            }
        }

        public void AddToCurrentStorage(int value)
        {
            currentStorage = Mathf.Clamp(currentStorage + value, 0, maxStorage);
            currentStorageChangedEvent.Invoke();
        }

        public void RemoveFromCurrentStorage(int value)
        {
            currentStorage = Mathf.Clamp(currentStorage - value, 0, maxStorage);
            currentStorageChangedEvent.Invoke();
        }
    }
}