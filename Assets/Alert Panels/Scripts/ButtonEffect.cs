using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace com.ondad.alertpanels
{
    public class ButtonEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [Header("Scale Settings")]
        [SerializeField] private float hoveredScale = 1.2f;
        [SerializeField] private float normalScale = 1.0f;
        [SerializeField] private float animationDuration = 0.25f;
        [SerializeField] private float bounceStrength = 0.5f; // Controls how pronounced the bounce is

        private int tweenId;

        private void OnDisable()
        {
            // Cancel any active tweens when the object is disabled
            LeanTween.cancel(tweenId);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            // Cancel any existing tween
            LeanTween.cancel(tweenId);
            // Create new tween with bounce effect
            tweenId = LeanTween.scale(eventData.pointerEnter.gameObject, Vector3.one * hoveredScale, animationDuration)
                .setEase(LeanTweenType.easeOutBounce) // Bounce effect when scaling up
                .setOvershoot(bounceStrength) // Adjust bounce intensity
                .id;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            // Cancel any existing tween
            LeanTween.cancel(tweenId);

            // Create new tween with bounce effect
            tweenId = LeanTween.scale(eventData.pointerEnter.gameObject, Vector3.one * normalScale, animationDuration)
                .setEase(LeanTweenType.easeOutBounce) // Bounce effect when scaling down
                .setOvershoot(bounceStrength) // Adjust bounce intensity
                .id;
        }
    }
}
