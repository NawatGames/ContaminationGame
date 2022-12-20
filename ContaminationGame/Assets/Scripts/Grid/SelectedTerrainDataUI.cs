using UnityEngine;
using UnityEngine.UI;

public class SelectedTerrainDataUI : MonoBehaviour
{
    [SerializeField] private Text nucleotidesText;
    [SerializeField] private Text netFeeText;
    [SerializeField] private TerrainSelectionManager terrainSelectionManager;

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
        if (terrainSelectionManager.TerrainData == null)
        {
            nucleotidesText.text = $"Nucletideos: ERRO";
            netFeeText.text = $"Transmissao: ERRO";
        }
        else
        {
            nucleotidesText.text = $"{terrainSelectionManager.TerrainData.Nucleotides}";
            netFeeText.text = $"{terrainSelectionManager.TerrainData.NetFee}";
        }
    }
}