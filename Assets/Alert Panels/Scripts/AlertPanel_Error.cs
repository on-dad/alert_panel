using System;
using UnityEngine;
using UnityEngine.UI;

namespace com.ondad.alertpanels
{
    public class AlertPanel_Error : AlertPanel
    {
        [SerializeField] private Button okeyBtn;
        Action okeyAction;

        private void Awake()
        {
            okeyBtn.onClick.AddListener(OkeyBtn);
        }

        public void ShowPanel(string bodyContent, Action exitAction = null, Action okeyAction = null)
        {
            if (okeyAction != null) this.okeyAction = okeyAction;
            ShowPanel(bodyContent, exitAction);
        }

        void OkeyBtn()
        {
            if (okeyAction != null)
            {
                okeyAction.Invoke();
                okeyAction = null;
            }
        }
    }
}
