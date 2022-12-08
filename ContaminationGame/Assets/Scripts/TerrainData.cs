using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TerrainData : MonoBehaviour
{
    [SerializeField] public int nucleotides;
    [SerializeField] public int grossFee;
    [SerializeField] public int netFee;
    [SerializeField] public int cureFee;
    [SerializeField] private int stateControl = 0;
    
    private void Start()
    {
        netFee = grossFee - cureFee;
    }
    
}