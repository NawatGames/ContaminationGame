﻿using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUI : MonoBehaviour
{
    
    [SerializeField] private TMP_Text nucleotidesText; 
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
        nucleotidesText.text = $"{playerInfo.PlayerNucleotides}";
    }
   
}