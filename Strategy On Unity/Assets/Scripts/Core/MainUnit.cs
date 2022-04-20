using Abstractions;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Assets.Scripts.Core
{
    internal class MainUnit : MonoBehaviour, ISelectable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;
        
        [SerializeField] private float _maxHealth = 50;
        [SerializeField] private Sprite _icon;

        private float _health = 50;
        
    }
}
