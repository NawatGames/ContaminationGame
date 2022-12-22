using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] public int nucleotides;
    [SerializeField] public int netFee;
    [SerializeField] private List<TerrainData> _terrainDatas = new List<TerrainData>();
    public UnityEvent PlayerInfoChangedEvent;
    
    

    private void OnEnable()
    {
        foreach (var terrainData in _terrainDatas)
        {
            terrainData.TerrainDataChangedEvent.AddListener(Refresh);
        }
    }

    private void OnDisable()
    {
        foreach (var terrainData in _terrainDatas)
        {
            terrainData.TerrainDataChangedEvent.RemoveListener(Refresh);
        }
    }

    public void AddTerrain(TerrainData terrainData)
    {
        _terrainDatas.Add(terrainData);
        terrainData.TerrainDataChangedEvent.AddListener(Refresh);
    }

    [ContextMenu("Refresh")]
    
    void Refresh()
    {
        nucleotides = 0;
        netFee = 0;
        foreach (var terrainData in _terrainDatas)
        {
            nucleotides += terrainData.Nucleotides;
            netFee += terrainData.NetFee;
        }

        PlayerInfoChangedEvent.Invoke();
    }
}