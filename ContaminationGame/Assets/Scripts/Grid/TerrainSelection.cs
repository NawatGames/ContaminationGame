using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TerrainSelection : MonoBehaviour
{
    public UnityEvent selectedEvent;
    public UnityEvent deselectedEvent;

    private void OnTriggerEnter2D(Collider2D other)
    {
        selectedEvent.Invoke();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        deselectedEvent.Invoke();
    }
}