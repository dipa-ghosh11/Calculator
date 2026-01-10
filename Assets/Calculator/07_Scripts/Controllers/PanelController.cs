using Assets.Calculator._07_Scripts.Interfaces;
using Assets.Calculator._07_Scripts.Models;
using UnityEngine;

namespace Assets.Calculator._07_Scripts.Controllers
{
    public class PanelController : IEventListener
    {
        private Callback _callback;
        private GameObject _mainPanel;
        private GameObject _historyPanel;

        public PanelController(Panels gamePanels, Callback callback)
        {
            _mainPanel = gamePanels.mainPanel;
            _historyPanel = gamePanels.historyPanel;
            _callback = callback;

            InitialPanelState();
        }

        public void Subscribe()
        {
            Callback.OnMainPanelActivation += ActivateMainPanel;
            Callback.OnHistoryPanelActivation += ActivateHistoryPanel;
        }


        public void Unsubscribe()
        {
            Callback.OnMainPanelActivation -= ActivateMainPanel;
            Callback.OnHistoryPanelActivation -= ActivateHistoryPanel;
        }


        private void ActivateMainPanel(bool isActive)
        {
            _mainPanel.SetActive(isActive);
        }

        private void ActivateHistoryPanel(bool isActive)
        {
            _historyPanel?.SetActive(isActive);
        }

        private void InitialPanelState()
        {
            _mainPanel.SetActive(true);
            _historyPanel.SetActive(false);
        }
    }
}
