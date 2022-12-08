using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AreaInfoUI : MonoBehaviour
{
    public static AreaInfoUI Instance;
    [SerializeField] private GameObject _selectedTileNucleotidesObject;
    [SerializeField] private GameObject _selectedTileGrossFeeObject;
    [SerializeField] private GameObject _selectedTileNetFeeObject;
    [SerializeField] private GameObject _selectedTileCureFeeObject;

 
    private void Awake()
    {
        Instance = this;
    }

    public void ShowSelectedTile(TerrainData terrain)
    {
        if (terrain == null)
        {
            _selectedTileNucleotidesObject.SetActive(false);
            _selectedTileGrossFeeObject.SetActive(false);
            _selectedTileNetFeeObject.SetActive(false);
            _selectedTileCureFeeObject.SetActive(false);
            return;
        }

        _selectedTileNucleotidesObject.GetComponentInChildren<Text>().text = "Nt: " + terrain.nucleotides.ToString();
        _selectedTileGrossFeeObject.GetComponentInChildren<Text>().text = "Gross: " + terrain.grossFee.ToString();
        _selectedTileNetFeeObject.GetComponentInChildren<Text>().text = "Net: " + terrain.netFee.ToString();
        _selectedTileCureFeeObject.GetComponentInChildren<Text>().text = "Cure: " + terrain.cureFee.ToString();
        _selectedTileNucleotidesObject.SetActive(true);
        _selectedTileGrossFeeObject.SetActive(true);
        _selectedTileNetFeeObject.SetActive(true);
        _selectedTileCureFeeObject.SetActive(true);
    }
   
}