using System;
using System.Collections;
using System.Collections.Generic;
using EvolutionSystem;
using NucleotidesProduction;
using StateMachine2;
using UnityEngine;
using UnityEngine.Events;

public class TerrainData : MonoBehaviour
{
    [field: SerializeField] public TerrainCost TerrainCost { get; private set; }
    //Acessa a variavel privada dentro da propriedade
    [field: SerializeField] public VerifierStorageCondition VerifierStorageCondition { get; private set; }
    [field: SerializeField] public TileNucleotidesTransferer TileNucleotidesTransferer { get; private set; }
    
    [field: SerializeField] public NucleotidesGenerator NucleotidesGenerator { get; private set; }
    [field: SerializeField] public AreaStateMachine AreaStateMachine { get; private set; }

}


