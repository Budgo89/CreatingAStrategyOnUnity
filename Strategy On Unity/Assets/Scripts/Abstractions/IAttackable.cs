namespace Abstractions
{
    public interface IAttackable : IHealthHolder
    {
        public IAttackable Target { get; }
    }
}
