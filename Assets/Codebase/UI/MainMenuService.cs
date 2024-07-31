using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Assets.Codebase.UI
{
    public class MainMenuService : MonoBehaviour
    {
        private Fade _fade;

        [SerializeField]
        private float _fadeDuration;

        [Inject]
        private void Construct(Fade fade)
        {
            _fade = fade;
        }

        private void Start()
        {
            Time.timeScale = 1f;
        }

        public void Activate(CanvasGroup canvasGroup)
        {
            _fade.FadeIn(_fadeDuration, canvasGroup, () => { Debug.Log("FadeIn is end."); });
            canvasGroup.blocksRaycasts = true;
        }
        public void Deactivate(CanvasGroup canvasGroup)
        {
            _fade.FadeOut(_fadeDuration, canvasGroup, () => { Debug.Log("FadeOut is end."); });
            canvasGroup.blocksRaycasts = false;
        }

        public void Play() => SceneManager.LoadScene(1);
        public void Exit() => Application.Quit();
    }
}