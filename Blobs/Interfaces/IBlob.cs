namespace Blobs.Interfaces
{
    public interface IBlob : IGameObject, IAttacker, IDestroyable
    {
        IBehavior Behavior { get; set; }

        IAttack AttackType { get; set; }
    }
}