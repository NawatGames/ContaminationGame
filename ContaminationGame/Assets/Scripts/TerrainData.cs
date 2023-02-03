using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using NucleotidesProduction;
using UnityEngine;
using UnityEngine.Events;

public class TerrainData : MonoBehaviour
{
    [field: SerializeField] public TerrainCost TerrainCost { get; private set; }
    //Acessa a variavel privada dentro da propriedade
    [field: SerializeField] public VerifierStorageCondition VerifierStorageCondition { get; private set; }
    [field: SerializeField] public TileNucleotidesTransferer TileNucleotidesTransferer { get; private set; }
    
}


