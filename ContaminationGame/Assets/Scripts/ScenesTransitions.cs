using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesTransitions : MonoBehaviour
{
    [SerializeField] private string GameScene;
    
    public void Jogar()
    {
        SceneManager.LoadScene(GameScene);
    }

}
