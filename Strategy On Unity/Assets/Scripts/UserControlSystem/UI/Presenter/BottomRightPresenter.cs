using Abstractions;
using UnityEngine;
using UnityEngine.UI;

namespace UserControlSystem.UI.Presenter
{
    internal class BottomRightPresenter : MonoBehaviour
    {
        [SerializeField] private Button _moveButton;
        [SerializeField] private Button _attackButton;
        [SerializeField] private Button _patrolButton;
        [SerializeField] private Button _holdPositionButton;

        [SerializeField] private SelectableValue _selectedValue;

        private void Start()
        {
            _selectedValue.OnSelected += ONSelected;
            ONSelected(_selectedValue.CurrentValue);
        }

        private void ONSelected(ISelectable selected)
        {
            if (selected != null)
            {
                OnButtons();
            }
            else
            {
                OffButtons();
            }
        }

        private void OnButtons()
        {
            _moveButton.gameObject.SetActive(true);
            _attackButton.gameObject.SetActive(true);
            _patrolButton.gameObject.SetActive(true);
            _holdPositionButton.gameObject.SetActive(true);
        }

        private void OffButtons()
        {
            _moveButton.gameObject.SetActive(false);
            _attackButton.gameObject.SetActive(false);
            _patrolButton.gameObject.SetActive(false);
            _holdPositionButton.gameObject.SetActive(false);
        }
    }
}
