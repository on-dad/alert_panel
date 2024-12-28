using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace com.ondad.alertpanels
{
    public class AlertManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject blurBG;
        [SerializeField]
        private AlertPanel_Info alertInfo;

        private static AlertManager _instance;

        public static AlertManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<AlertManager>();
            }
            return _instance;
        }

        public void Enable_Disable_BlurImg(bool isBlurImgActive)
        {
            blurBG.SetActive(isBlurImgActive);
        }

        public void ShowInfoPanel(string bodyContent, Action exitAction = null)
        {
            alertInfo.ShowPanel(bodyContent, exitAction);
        }

    }
}
