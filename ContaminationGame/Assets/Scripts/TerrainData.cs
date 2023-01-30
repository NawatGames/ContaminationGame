using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TerrainData : MonoBehaviour
{
    [SerializeField] private int nucleotidesCost;
    public UnityEvent TerrainDataChangedEvent;

    public int Nucleotides
    {
        get => nucleotidesCost;
        set
        {
            nucleotidesCost = value;
            TerrainDataChangedEvent.Invoke();
        }
    }
}


