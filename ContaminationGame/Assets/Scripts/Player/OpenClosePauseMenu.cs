using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClosePauseMenu : MonoBehaviour
{
   [SerializeField] private PlayerInput playerInput;
   [SerializeField] private Transform pauseMenu; 

   private void OnEnable()
   {
      playerInput.OpenClosePauseMenuEvent.AddListener(OnOpenClosePauseMenu);
   }

   private void OnDisable()
   {
      playerInput.OpenClosePauseMenuEvent.RemoveListener(OnOpenClosePauseMenu);
   }

   private void OnOpenClosePauseMenu()
   {
      if (pauseMenu.gameObject.activeSelf)
      {
         pauseMenu.gameObject.SetActive(false);
         Time.timeScale = 1; //velocidade em que o jogo flui
      }
      else
      {
         pauseMenu.gameObject.SetActive(true);
         Time.timeScale = 0;
      }
   }
}
