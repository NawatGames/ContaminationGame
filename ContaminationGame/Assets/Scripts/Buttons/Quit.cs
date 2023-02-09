using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    [SerializeField] private float delayTime;

    private IEnumerator QuitCoroutine()
    {
        yield return new WaitForSeconds(delayTime);
        Application.Quit();
    }

    public void Sair()
    {
        StartCoroutine(QuitCoroutine());
    }
}
