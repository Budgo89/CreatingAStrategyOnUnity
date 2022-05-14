using System;
using Abstractions;
using UniRx;
using UnityEngine;
using UserControlSystem;
using Zenject;

public class OutlineSelectorPresenter : MonoBehaviour
{
    [Inject] private IObservable<ISelectable> _selectbleValue;

    private OutlineSelector[] _outlineSelectors;
    private ISelectable _currentSelectable;

    private void Start()
    {
        _selectbleValue.Subscribe(OnSelected);
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
            if (selectors != null)
            {
                for (int i = 0; i < selectors.Length; i++)
                {
                    selectors[i].SetSelected(value);
                }
            }
        }
    }

}
