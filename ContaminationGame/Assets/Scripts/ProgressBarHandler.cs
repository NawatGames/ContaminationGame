using System;
using System.Collections;
using System.Collections.Generic;
using NucleotidesProduction;
using StateMachine2;
using UnityEngine;

public class ProgressBarHandler : MonoBehaviour
{
    // todo: Tentar finalizar a barra de progresso; Como adicionar um Canvas somente a um objeto em cena 
    [SerializeField] private NucleotideTileStorage nucleotideTileStorage;
    //[SerializeField] private NucleotidesGenerator nucleotidesGenerator;
    [SerializeField] private AreaStateMachine areaStateMachine;
    [SerializeField] private AreaState initialAreaState;
    [SerializeField] private GameObject progressBarFill;

    private void OnEnable()
    {
        nucleotideTileStorage.currentStorageChangedEvent.AddListener(FillProgressBar);
    }

    private void OnDisable()
    {
        nucleotideTileStorage.currentStorageChangedEvent.RemoveListener(FillProgressBar);
    }

    private void FillProgressBar()
    {
        if (areaStateMachine.CurrentState != initialAreaState)
        {
            var currentNucleotides = nucleotideTileStorage.CurrentStorage;
            var maxNucleotides = nucleotideTileStorage.MaxStorage;
            progressBarFill.transform.localScale = new Vector3(currentNucleotides / maxNucleotides - 0.15f , 0.2f, 1);
        }
        else
        {
            progressBarFill.transform.localScale = new Vector3(0, 0.2f, 1);
        }
    }
}
