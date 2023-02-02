using System;
using System.Collections;
using System.Collections.Generic;
using NucleotidesProduction;
using StateMachine2;
using UI;
using UnityEngine;

public class ProgressBarHandler : MonoBehaviour
{
    [SerializeField] private ProgressBar progressBar;
    [SerializeField] private NucleotideTileStorage nucleotideTileStorage;
    

    private void OnEnable()
    {
        nucleotideTileStorage.currentStorageChangedEvent.AddListener(OnCurrentStorageChanged);
    }

    private void OnDisable()
    {
        nucleotideTileStorage.currentStorageChangedEvent.RemoveListener(OnCurrentStorageChanged);
    }

    private void OnCurrentStorageChanged()
    {
        var currentStorage = nucleotideTileStorage.CurrentStorage;
        var maxStorage = nucleotideTileStorage.MaxStorage;
        var percentage = (float) currentStorage / maxStorage;
        progressBar.SetPercentage(percentage);
    }
}
