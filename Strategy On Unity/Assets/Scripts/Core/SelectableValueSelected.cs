using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Assets.Scripts.Core
{
    [CreateAssetMenu(fileName = nameof(SelectableValueSelected), menuName = "Strategy Game/" + nameof(SelectableValueSelected),
        order = 0)]
    public class SelectableValueSelected : ScriptableObject
    {
        public ISelectable CurrentValue { get; private set; }
        public Action<ISelectable> OnSelected;

        public void SetValue(ISelectable value)
        {
            CurrentValue = value;
            OnSelected?.Invoke(value);
        }
    }
}
