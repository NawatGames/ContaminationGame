using System.Collections;
using UnityEngine;

namespace NucleotidesProduction
{
    public class NucleotidesGenerator : MonoBehaviour
    {
        [SerializeField] private float delayTime;
        [SerializeField] private int netFee;
        [SerializeField] private NucleotideTileStorage nucleotideTileStorage;
        public int NetFee
        {
            get => netFee;
            set
            {
                netFee = value;
                Refresh();
            }
        }
        public float DelayTime
        {
            get => delayTime;
            set
            {
                delayTime = value;
                Refresh();
            } 
        }
        public IEnumerator Start()
        {
            while (true)
            {
                yield return new WaitForSeconds(delayTime);
                nucleotideTileStorage.AddToCurrentStorage(netFee);
            }
            yield break;
        }

        public void Refresh()
        {
            StopAllCoroutines();
            StartCoroutine(Start());
        }
    }
}