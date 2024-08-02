using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Assets.Codebase.UI
{
    public class GameplayMenu : MonoBehaviour
    {
        [SerializeField]
        private float _fadeDuration;
        [SerializeField]
        private GameObject _activateButton;

        private Fade _fade;

        [Inject]
        private void Construct(Fade fade)
        {
            _fade = fade;
        }

        public virtual void Start()
        {
            Deactivate();
        }

        public void Activate()
        {
            _activateButton?.SetActive(false);
            _fade.FadeIn(_fadeDuration, GetComponent<CanvasGroup>(), () =>
            {
                Time.timeScale = 0f;
            });
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
        public void Deactivate()
        {
            Time.timeScale = 1f;
            _activateButton?.SetActive(true);
            _fade.FadeOut(_fadeDuration, GetComponent<CanvasGroup>(), () =>
            {
                Time.timeScale = 1f;
            });
            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
        public void Reset()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        public void Exit()
        {
            SceneManager.LoadScene(0);
        }
    }
}

