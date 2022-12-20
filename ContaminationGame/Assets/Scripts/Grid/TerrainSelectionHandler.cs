using System;
using UnityEngine;

public class TerrainSelectionHandler : MonoBehaviour
{
    private TerrainSelectionManager terrainSelectionManager;
    [SerializeField] private TerrainSelection terrainSelection;
    [SerializeField] private TerrainData terrainData;

    private void Awake()
    {
        terrainSelectionManager = GameObject.FindObjectOfType<TerrainSelectionManager>();
    }

    private void OnEnable()
    {
        terrainSelection.selectedEvent.AddListener(OnTerrainSelection);
        terrainSelection.deselectedEvent.AddListener(OnTerrainDeselection);
    }

    private void OnDisable()
    {
        terrainSelection.selectedEvent.RemoveListener(OnTerrainSelection);
        terrainSelection.deselectedEvent.RemoveListener(OnTerrainDeselection);
    }

    private void OnTerrainSelection()
    {
        terrainSelectionManager.SetTerrainData(terrainData);
    }

    private void OnTerrainDeselection()
    {
        if (terrainSelectionManager.TerrainData == terrainData)
        {
            terrainSelectionManager.SetTerrainData(null);
        }
        
    }
}