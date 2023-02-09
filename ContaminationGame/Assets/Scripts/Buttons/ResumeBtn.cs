using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace Buttons
{
    public class ResumeBtn : MonoBehaviour
    {
        [FormerlySerializedAs("pauseMenu")] [SerializeField] private Transform menu;

        private IEnumerator WaitCoroutine()
        {
            yield return new WaitForSeconds(0.5f);
            menu.gameObject.SetActive(false);
        }
        
        public void Resume()
        {
            StartCoroutine(WaitCoroutine());
            Time.timeScale = 1;
        }
    }
}