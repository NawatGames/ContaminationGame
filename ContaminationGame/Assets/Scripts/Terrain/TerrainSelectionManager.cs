using UnityEngine;
using UnityEngine.Events;

public class TerrainSelectionManager : MonoBehaviour
{
    [SerializeField] private TerrainData terrainData;
    public UnityEvent SelectionChangedEvent;
    
    public TerrainData TerrainData => terrainData;

    public void SetTerrainData(TerrainData terrainData)
    {
        this.terrainData = terrainData;
        SelectionChangedEvent.Invoke();
    }
}