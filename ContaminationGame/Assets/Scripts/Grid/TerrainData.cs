using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainData : MonoBehaviour
{
    [SerializeField] public int nucleotides;
    [SerializeField] public int grossFee;
    [SerializeField] public int netFee;
    [SerializeField] public int cureFee;
    [SerializeField] private int stateControl = 0;

    [SerializeField] private GameObject _highlight;


    private void Start()
    {
        netFee = grossFee - cureFee;
    }

    // private void OnMouseEnter()
    // {
    //     _highlight.SetActive(true);
    //     MenuManager.Instance.ShowSelectedTile(this);
    // }

    // private void OnMouseExit()
    // {
    //     _highlight.SetActive(false);
    //     MenuManager.Instance.ShowSelectedTile(null);
    // }


    // private void OnMouseDown()
    // {
    //     _highlight.SetActive(true);
    //     MenuManager.Instance.ShowSelectedTile(this);
    // }

    // private void OnMouseUp()
    // {
    //     _highlight.SetActive(false);
    //     //MenuManager.Instance.ShowSelectedTile(null);
    // }
 
    private void OnTriggerStay2D(Collider2D other)
    {
        
            _highlight.SetActive(true);
            MenuManager.Instance.ShowSelectedTile(this);
        
    }

    private void OnTriggerExit2D(Collider2D other) {
        _highlight.SetActive(false);
        MenuManager.Instance.ShowSelectedTile(null);
    }
    
}