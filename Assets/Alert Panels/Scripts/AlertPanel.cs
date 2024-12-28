using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace com.ondad.alertpanels
{
    public class AlertPanel : MonoBehaviour
    {
        private GameObject _pointedGO;
        private Vector2 _pointedGOinitScale;

        public void OnHover(BaseEventData eventData)
        {
            Debug.Log("Hovers!");

            _pointedGO = eventData.selectedObject;
            Debug.Log(_pointedGO.name);
            _pointedGOinitScale = _pointedGO.transform.localScale;
            _pointedGO.transform.localScale = _pointedGOinitScale * 1.1f;

        }

        public void OnExitHover()
        {
            if (_pointedGO != null)
            {
                _pointedGO.transform.localScale = _pointedGOinitScale;
                _pointedGO = null;
            }
        }

        public void OnClick()
        {

        }
    }
}
