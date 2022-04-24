using Abstractions;
using UnityEngine;

namespace Core
{
    public class MainUnit : MonoBehaviour, ISelectable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Transform PivotPoint => _pivotPoint;
        public Sprite Icon => _icon;

        [SerializeField] private Transform _pivotPoint;
        [SerializeField] private float _maxHealth = 100;
        [SerializeField] private Sprite _icon;

        private float _health = 100;
    }
}