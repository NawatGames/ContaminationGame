using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TerrainData : MonoBehaviour
{
    [SerializeField] private int nucleotides;
    [SerializeField] private int netFee;
    public UnityEvent TerrainDataChangedEvent;

    public int Nucleotides
    {
        get => nucleotides;
        set
        {
            nucleotides = value;
            TerrainDataChangedEvent.Invoke();
        }
    }

    public int NetFee
    {
        get => netFee;
        set
        {
            netFee = value;
            TerrainDataChangedEvent.Invoke();
        }
    }
}
