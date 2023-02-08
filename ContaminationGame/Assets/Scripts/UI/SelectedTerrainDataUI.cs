using System;
using NucleotidesProduction;
using StateMachine2;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelectedTerrainDataUI : MonoBehaviour
{
    [SerializeField] private TMP_Text nucleotidesText;
    [SerializeField] private TMP_Text netFeeText;
    [SerializeField] private TMP_Text currentStateText;
    [SerializeField] private TerrainSelectionManager terrainSelectionManager;

    private void Update()
    {
        RefreshPlayerInfoUI();
    }

    private void OnEnable()
    {
        terrainSelectionManager.SelectionChangedEvent.AddListener(RefreshPlayerInfoUI);
    }

    private void OnDisable()
    {
        terrainSelectionManager.SelectionChangedEvent.RemoveListener(RefreshPlayerInfoUI);
    }

    public void RefreshPlayerInfoUI()
    {
        if (terrainSelectionManager.TerrainData is null)
        {
            nucleotidesText.text = $"Nucletideos: ERRO";
            netFeeText.text = $"Transmissao: ERRO";
            currentStateText.text = $"Estado: ERRO";
        }
        else
        {
            nucleotidesText.text = $"{terrainSelectionManager.TerrainData.TerrainCost.Nucleotides}";
            var netFee = terrainSelectionManager.TerrainData.NucleotidesGenerator.NetFee;
            netFeeText.text = $"{netFee}";
            var currentState = terrainSelectionManager.TerrainData.AreaStateMachine.CurrentState.areaStateName;
            currentStateText.text = $"{currentState}";
        }
    }
}