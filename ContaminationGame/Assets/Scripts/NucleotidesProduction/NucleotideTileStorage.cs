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

        public int CurrentStorage => currentStorage;

        public void SetCurrentStorage(int value)
        {
            var lastFrameStorage = currentStorage;
            currentStorage = Mathf.Clamp(value, 0, maxStorage);
            currentStorageChangedEvent.Invoke();
        }
        public void AddToCurrentStorage(int value)
        {
            var lastFrameStorage = currentStorage;
            currentStorage = Mathf.Clamp(currentStorage + value, 0, maxStorage);
            if (currentStorage != lastFrameStorage)
            {
                currentStorageChangedEvent.Invoke();
            }
        }

        public void RemoveFromCurrentStorage(int value)
        {
            var lastFrameStorage = currentStorage;
            currentStorage = Mathf.Clamp(currentStorage - value, 0, maxStorage);
            if (currentStorage != lastFrameStorage)
            {
                currentStorageChangedEvent.Invoke();
            }
        }
    }
}