using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainData : MonoBehaviour
{
    [SerializeField] private int nucleotides;
    [SerializeField] private int grossFee;
    [SerializeField] private int netFee;
    [SerializeField] private int cureFee;
    [SerializeField] private int stateControl = 0;


    private void Start()
    {
        netFee = grossFee - cureFee;
    }
}
