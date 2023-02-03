using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private int playerNucleotides;
    
    public UnityEvent PlayerInfoChangedEvent;
   
    public int PlayerNucleotides => playerNucleotides;
    public static PlayerInfo instance;

    private void Awake()
    {
        instance = this;
    }

    public void SetPlayerNucleotides(int value)
    {
        playerNucleotides = value;
        Refresh();
    }
    
    public void AddPlayerNucleotides(int value)
    {
        playerNucleotides += value;
        Refresh();
    }
    public void RemovePlayerNucleotides(int value)
    {
        playerNucleotides -= value;
        Refresh();
    }
    
    [ContextMenu("Refresh")]
    
    void Refresh()
    {
        PlayerInfoChangedEvent.Invoke();
    }

    private void Start()
    {
        Refresh();
    }
}