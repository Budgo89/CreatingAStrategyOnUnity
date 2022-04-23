using Abstractions;
using UnityEngine;

namespace UserControlSystem.UI.Presenter
{
    public class OutlineSelectorPresenter : MonoBehaviour
    {
        [SerializeField] private SelectableValue _selectable;

        private OutlineSelector[] _outlineSelectors;
        private ISelectable _currentSelectable;
        private void Start()
        {
            _selectable.OnSelected += OnSelected;
        }
        private void OnSelected(ISelectable selectable)
        {
            if (_currentSelectable == selectable)
            {
                return;
            }

            SetSelected(_outlineSelectors, false);
            _outlineSelectors = null;

            if (selectable != null)
            {
                _outlineSelectors = (selectable as Component).GetComponentsInParent<OutlineSelector>();
                SetSelected(_outlineSelectors, true);
            }
            else
            {
                if (_outlineSelectors != null)
                {
                    SetSelected(_outlineSelectors, false);
                }
            }

            _currentSelectable = selectable;

            static void SetSelected(OutlineSelector[] selectors, bool value)
            {
                if (selectors == null) return;
                foreach (var selector in selectors)
                {
                    selector.SetSelected(value);
                }
            }
        }
    }
}
