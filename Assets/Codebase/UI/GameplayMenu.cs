using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using System;

namespace Assets.Codebase.UI
{
    public class GameplayMenu : MonoBehaviour
    {
        [SerializeField]
        private float _fadeDuration;

        public virtual void Start()
        {
            Deactivate();
        }

        public void Activate()
        {
            FadeIn(_fadeDuration, GetComponent<CanvasGroup>());
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
        public void Deactivate()
        {
            Time.timeScale = 1f;
            FadeOut(_fadeDuration, GetComponent<CanvasGroup>());
            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
        public void Reset()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        public void Exit()
        {
            Application.Quit();
        }

        private void FadeIn(float duration, CanvasGroup canvasGroup)
        {
            FadeCanvasGroup(1f, duration, canvasGroup,
                () =>
                {
                    Time.timeScale = 0f;
                    Debug.Log("FadeIn animation is end");
                });
        }
        private void FadeOut(float duration, CanvasGroup canvasGroup)
        {
            FadeCanvasGroup(0f, duration, canvasGroup,
                () =>
                {
                    Debug.Log("FadeOut animation is end");
                });
        }

        private void FadeCanvasGroup(float fadeValue, float duration, CanvasGroup canvasGroup, TweenCallback onEnd)
        {
            canvasGroup.DOFade(fadeValue, duration).OnComplete(onEnd);
        }
    }
}
    
