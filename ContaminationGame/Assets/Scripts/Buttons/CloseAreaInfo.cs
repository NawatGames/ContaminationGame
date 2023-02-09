using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAreaInfo : MonoBehaviour
{
    [SerializeField] private Transform infoMenu;

    public void Close()
    {
        infoMenu.gameObject.SetActive(false);
    }
}
