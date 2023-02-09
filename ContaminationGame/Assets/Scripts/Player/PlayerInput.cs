using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class PlayerInput : MonoBehaviour
{
    public UnityEvent <Vector3> directionChangedEvent;
    [FormerlySerializedAs("evolutionRequestEvent")] public UnityEvent EvolutionRequestEvent;
    public UnityEvent CollectNucleotidesRequestEvent;
    [FormerlySerializedAs("OpenClosePauseMenu")] [FormerlySerializedAs("EscapeKeyDownEvent")] public UnityEvent OpenClosePauseMenuEvent;

    void Update()
    {
        Vector3 direction = Vector3.zero;
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector3.down;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector3.right;
        }

        if (direction != Vector3.zero)
        {
            directionChangedEvent.Invoke(direction);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            EvolutionRequestEvent.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            CollectNucleotidesRequestEvent.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenClosePauseMenuEvent.Invoke();
        }
    }
}