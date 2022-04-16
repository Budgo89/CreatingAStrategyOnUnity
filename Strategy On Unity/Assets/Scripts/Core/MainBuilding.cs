using Abstractions;
using Assets.Scripts.Core;
using UnityEngine;

namespace Core
{
    public sealed class MainBuilding : MonoBehaviour, IUnitProducer, ISelectable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;

        [SerializeField] private GameObject _unitPrefab;
        [SerializeField] private Transform _unitsParent;

        [SerializeField] private float _maxHealth = 1000;
        [SerializeField] private Sprite _icon;
        [SerializeField] private GameObject _selection;

        private float _health = 1000;

        [SerializeField] private SelectableValueSelected _selectedValueSelected;

        private void Start()
        {
            _selectedValueSelected.OnSelected += OnClick;
            OnClick(_selectedValueSelected.CurrentValue);
        }

        public void ProduceUnit()
        {
            Instantiate(_unitPrefab,
                new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)),
                Quaternion.identity,
                _unitsParent);
        }

        private void ONSelected(ISelectable selected)
        {
            _selection.gameObject.SetActive(selected != null);
        }

        private void OnClick(ISelectable selected)
        {
            if (selected != null)
            {
                ProduceUnit();
            }

            ONSelected(selected);

        }
    }
}