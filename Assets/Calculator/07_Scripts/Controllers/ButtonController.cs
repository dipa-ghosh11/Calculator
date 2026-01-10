using Assets.Calculator._07_Scripts.Models;
using UnityEngine.UI;

namespace Assets.Calculator._07_Scripts.Controllers
{
    public class ButtonController
    {
        private Callback _callback;

        private Button _one;
        private Button _two;
        private Button _three;
        private Button _four;
        private Button _five;
        private Button _six;
        private Button _seven;
        private Button _eight;
        private Button _nine;
        private Button _zero;
        private Button _plus;
        private Button _minus;
        private Button _divide;
        private Button _mul;
        private Button _equal;
        private Button _clear;
        private Button _history;
        private Button _back;


        public ButtonController(Buttons gameButtons, Callback callback)
        {
            _callback = callback;
            _one = gameButtons.one;
            _two = gameButtons.two;
            _three = gameButtons.three;
            _four = gameButtons.four;
            _five = gameButtons.five;
            _eight = gameButtons.eight;
            _nine = gameButtons.nine;
            _zero = gameButtons.zero;
            _plus = gameButtons.plus;
            _minus = gameButtons.minus;
            _divide = gameButtons.divide;
            _mul = gameButtons.mul;
            _equal = gameButtons.equal;
            _clear = gameButtons.clear;
            _history = gameButtons.history;
            _back = gameButtons.back;
        }

        private void InitialState()
        {
            _history.onClick.AddListener(() =>
            {
                _callback.HistoryPanelActivation(true);
                _callback.MainPanelActivation(false);
            });

            _back.onClick.AddListener(() =>
            {
                _callback.MainPanelActivation(true);
                _callback.HistoryPanelActivation(false);
            });
        }
    }
}
