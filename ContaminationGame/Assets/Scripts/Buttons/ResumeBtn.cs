using System.Collections;
using UnityEngine;

namespace Buttons
{
    public class ResumeBtn : MonoBehaviour
    {
        [SerializeField] private Transform pauseMenu;

        public void Resume()
        {
            pauseMenu.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}