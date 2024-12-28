using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace com.ondad.alertpanels
{
    public class ButtonEffect : MonoBehaviour
    {
        private float bounceStrength = 0.5f; 

        private int tweenId;
        private float initScale;

        private void Start()
        {
            initScale = transform.localScale.x;

        }

        private void OnDisable()
        {
            // Cancel any active tweens when the object is disabled
            LeanTween.cancel(tweenId);
        }

        public void OnHover(PointerEventData eventData)
        {
            // Cancel any existing tween
            if (eventData.pointerEnter.GetComponent<Button>() == null) return;

            LeanTween.cancel(tweenId);
            // Create new tween with bounce effect
            tweenId = LeanTween.scale(eventData.pointerEnter.gameObject, Vector3.one * AlertPanel_Config.Instance.alertConfig.uiButtonHoverScale, AlertPanel_Config.Instance.alertConfig.uiBtnAnimSpeed)
                .setEase(LeanTweenType.easeOutBounce) // Bounce effect when scaling up
                .setOvershoot(bounceStrength) // Adjust bounce intensity
                .id;
        }

        public void OnExitHover(PointerEventData eventData)
        {
            if (eventData.pointerEnter.GetComponent<Button>() == null) return;

            // Cancel any existing tween
            LeanTween.cancel(tweenId);

            // Create new tween with bounce effect
            tweenId = LeanTween.scale(eventData.pointerEnter.gameObject, Vector3.one * initScale, AlertPanel_Config.Instance.alertConfig.uiBtnAnimSpeed)
                .setEase(LeanTweenType.easeOutBounce) // Bounce effect when scaling down
                .setOvershoot(bounceStrength) // Adjust bounce intensity
                .id;
        }
    }
}
