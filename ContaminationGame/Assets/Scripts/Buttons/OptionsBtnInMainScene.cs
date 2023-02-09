using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsBtnInMainScene : MonoBehaviour
{
    [SerializeField] private Transform pauseMenu;

    public void OpenMenu()
    {
        pauseMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
