using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class OpenAreaInformation : MonoBehaviour
{
    [FormerlySerializedAs("InfoMenu")] [SerializeField] private Transform infoMenu;

    public void Open()
    {
        infoMenu.gameObject.SetActive(true);
    }
}
