using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public struct Bounds2D
{
    public Vector2Int min;
    public Vector2Int max;
    public Bounds2D(Vector2Int min, Vector2Int max)
    {
        this.min = min;
        this.max = max;
    }
    public Bounds2D(int minX, int minY, int maxX, int maxY)
    {
        this.min = new Vector2Int(minX, minY);
        this.max = new Vector2Int(maxX, maxY);
    }

    public bool Contains(Vector2 point)
    {
        return (point.y >= min.y && point.y < max.y && point.x >= min.x && point.x < max.x);
    }
}

public class Selector : MonoBehaviour
{
    private bool isMoving;
    private Vector3 origPos, targetPos;
    private float timeToMove = 0.5f;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private float scale = 1.1f;
    [SerializeField] private Bounds2D map = new Bounds2D(0, 0, 6, 6);
    [SerializeField] private Vector3 playerPosition;

    // void Update()
    // {
    //     if (Input.GetKey(KeyCode.W) && !isMoving)
    //     {
    //         if (targetPos.y < 5.5)
    //         {
    //             StartCoroutine(MovePlayer(new Vector3(0, (float)1.1, 0)));
    //         }
    //     }
    //     if (Input.GetKey(KeyCode.S) && !isMoving)
    //     {
    //         if (targetPos.y > 1)
    //         {
    //             StartCoroutine(MovePlayer(new Vector3(0, -(float)1.1, 0)));
    //         }
    //     }
    //     if (Input.GetKey(KeyCode.A) && !isMoving)
    //     {
    //         if (targetPos.x > 1)
    //         {
    //             StartCoroutine(MovePlayer(new Vector3(-(float)1.1, 0, 0)));
    //         }
    //     }
    //     if (Input.GetKey(KeyCode.D) && !isMoving)
    //     {
    //         if (targetPos.x < 5.5)
    //         {
    //             StartCoroutine(MovePlayer(new Vector3((float)1.1, 0, 0)));
    //         }
    //     }
    // }

    private void OnEnable()
    {
        _playerInput.directionChangedEvent.AddListener(StartMovePlayer);
    }

    private void OnDisable()
    {
        _playerInput.directionChangedEvent.RemoveListener(StartMovePlayer);
    }

    private void StartMovePlayer(Vector3 direction)
    {
        var isInsideTheArea = map.Contains(playerPosition + direction);
        if (isInsideTheArea && !isMoving)
        {
            playerPosition += direction;
            StartCoroutine(MovePlayer(direction * scale));
        }
    }

    private IEnumerator MovePlayer(Vector3 scaledDirection)
    {
        isMoving = true;

        float elapsedTime = 0;



        origPos = transform.position;
        targetPos = origPos + scaledDirection;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;

        isMoving = false;
    }
}
