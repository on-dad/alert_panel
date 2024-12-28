using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.ondad.alertpanels
{
    public class TestAlert : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void ShowAlertPanelInfo()
        {
            AlertManager.GetInstance().ShowInfoPanel("Test");
        }
    }
}
