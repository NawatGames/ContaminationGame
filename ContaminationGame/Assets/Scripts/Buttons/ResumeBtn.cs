using System.Collections;
using UnityEngine;

namespace Buttons
{
    public class ResumeBtn : MonoBehaviour
    {
        [SerializeField] private Transform pauseMenu;

        private IEnumerator WaitCoroutine()
        {
            yield return new WaitForSeconds(0.5f);
            pauseMenu.gameObject.SetActive(false);
        }
        
        public void Resume()
        {
            StartCoroutine(WaitCoroutine());
            Time.timeScale = 1;
        }
    }
}