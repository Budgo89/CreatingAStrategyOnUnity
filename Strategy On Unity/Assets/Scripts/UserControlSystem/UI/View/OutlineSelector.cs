using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OutlineSelector : MonoBehaviour
{
    [SerializeField] private Outline[] _outlineComponents;

    private bool _isSelectedCache;

    private void Start() => DisableOutline();

    public void SetSelected(bool isSelected)
    {
        if (isSelected == _isSelectedCache)
            return;

        if (isSelected)
            EnableOutline();
        else
            DisableOutline();

        _isSelectedCache = isSelected;
    }

    private void DisableOutline()
    {
        foreach (var outlineComponent in _outlineComponents)
        {
            outlineComponent.enabled = false;
        }
    }

    private void EnableOutline()
    {
        foreach (var outlineComponent in _outlineComponents)
        {
            outlineComponent.enabled = true;
        }
    }
}
