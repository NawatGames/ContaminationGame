using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesTransitions : MonoBehaviour
{
    [SerializeField] private string GameScene;

    [SerializeField] private float delayTime;

    private IEnumerator TransitionCoroutine()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(GameScene);
    }
    public void Jogar()
    {
        StartCoroutine(TransitionCoroutine());
    }

}
