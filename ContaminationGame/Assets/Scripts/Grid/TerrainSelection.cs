using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TerrainSelection : MonoBehaviour
{
    [SerializeField] private TerrainData _terrainData;
    public UnityEvent selectedEvent;
    public UnityEvent deselectedEvent;
    
    private void OnTriggerStay2D(Collider2D other)
    {
        selectedEvent.Invoke();
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        deselectedEvent.Invoke();
    }

    private void OnEnable()
    {
        selectedEvent.AddListener(ShowTile);
        deselectedEvent.AddListener(HideTile);
    }

    private void OnDisable()
    {
        selectedEvent.RemoveListener(ShowTile);
        deselectedEvent.RemoveListener(HideTile);
    }

    private void ShowTile()
    {
        AreaInfoUI.Instance.ShowSelectedTile(_terrainData);
    }

    private void HideTile()
    {
        AreaInfoUI.Instance.ShowSelectedTile(null);
    }
}
