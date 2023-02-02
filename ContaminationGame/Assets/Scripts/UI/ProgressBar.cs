using System;
using UnityEngine;

namespace UI
{
    public class ProgressBar : MonoBehaviour
    {
        [SerializeField] private Transform transform;
        [SerializeField][Range(0, 1)] private float initialValue;

        [ContextMenu("Refresh")] 
        private void Start()
        {
            SetPercentage(initialValue);
        }

        public void SetPercentage(float percentage)
        {
            var position = transform.localPosition;
            position.x = percentage;
            transform.localPosition = position;
        }
    }
}