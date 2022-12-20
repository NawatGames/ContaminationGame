using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUI : MonoBehaviour
{
    
    [SerializeField] private Text nucleotidesText;
    [SerializeField] private Text netFeeText;
    [SerializeField] private PlayerInfo playerInfo;

    private void OnEnable()
    {
        playerInfo.PlayerInfoChangedEvent.AddListener(RefreshPlayerInfoUI);
    }

    private void OnDisable()
    {
        playerInfo.PlayerInfoChangedEvent.RemoveListener(RefreshPlayerInfoUI);
    }

    private void Start()
    {
        RefreshPlayerInfoUI();
    }

    public void RefreshPlayerInfoUI()
    {
        nucleotidesText.text = $"{playerInfo.nucleotides}";
        netFeeText.text = $"{playerInfo.netFee}";
    }
   
}