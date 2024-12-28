using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.ondad.alertpanels
{
    public class TestAlert : MonoBehaviour
    {
        public void ShowAlertPanelInfo()
        {
            AlertManager.GetInstance().ShowInfoPanel("Test");
        }

        public void ShowWarningPanelInfo()
        {
            AlertManager.GetInstance().ShowWarningPanel("Test");
        }
    }
}
