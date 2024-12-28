using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace com.ondad.alertpanels
{
    public class AlertPanel : MonoBehaviour
    {
        [SerializeField] private Button exitBtn;
        [SerializeField] private TextMeshProUGUI bodyBtn;

        private Vector2 initScale = Vector2.zero;
        private int tweenId;
        private float bounceStrength = 0.5f;
        private Action exitAction;

        private void Awake()
        {
            initScale = transform.localScale;
            exitBtn.onClick.AddListener(ExitPanel);
        }

        public void ShowPanel(string bodyContent, Action exitAction = null)
        {
            bodyBtn.text = bodyContent;
            if (exitAction != null) this.exitAction = exitAction;

            ShowAnimation();
        }

        void ExitPanel()
        {
            HideAnimation();

            if (exitAction != null)
            {
                exitAction.Invoke();
                exitAction = null;
            }
        }

        void ShowAnimation()
        {
            LeanTween.cancel(tweenId);
            EnablePanel();

            tweenId = LeanTween.scale(gameObject, initScale, AlertPanel_Config.Instance.alertConfig.uiPanelAnimSpeed)
                .setEase(LeanTweenType.easeInBounce)
                .setOvershoot(bounceStrength)
                .id;
        }

        void HideAnimation()
        {
            LeanTween.cancel(tweenId);

            tweenId = LeanTween.scale(gameObject, Vector2.zero, AlertPanel_Config.Instance.alertConfig.uiPanelAnimSpeed)
                .setEase(LeanTweenType.easeOutBounce)
                .setOvershoot(bounceStrength).setOnComplete(DisablePanel)
                .id;
        }

        protected void EnablePanel()
        {
            AlertManager.GetInstance().Enable_Disable_BlurImg(true);
            gameObject.SetActive(true);
        }
        protected void DisablePanel()
        {
            gameObject.SetActive(false);
            AlertManager.GetInstance().Enable_Disable_BlurImg(false);
        }
    }
}
