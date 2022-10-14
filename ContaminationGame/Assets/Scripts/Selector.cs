using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    private bool isMoving;
    private Vector3 origPos, targetPos;
    private float timeToMove = 0.5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) && !isMoving)
        {
            if (targetPos.y < 5.5)
            {
                StartCoroutine(MovePlayer(new Vector3(0, (float)1.1, 0)));
            }
        }
        if (Input.GetKey(KeyCode.S) && !isMoving)
        {
            if (targetPos.y > 1)
            {
                StartCoroutine(MovePlayer(new Vector3(0, -(float)1.1, 0)));
            }
        }
        if (Input.GetKey(KeyCode.A) && !isMoving)
        {
            if (targetPos.x > 1)
            {
                StartCoroutine(MovePlayer(new Vector3(-(float)1.1, 0, 0)));
            }
        }
        if (Input.GetKey(KeyCode.D) && !isMoving)
        {
            if (targetPos.x < 5.5)
            {
                StartCoroutine(MovePlayer(new Vector3((float)1.1, 0, 0)));
            }
        }
    }

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;



        origPos = transform.position;
        targetPos = origPos + direction;

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
