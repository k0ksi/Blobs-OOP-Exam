namespace Blobs.Interfaces
{
    public interface IAttack
    {
        IBlob Attacker { get; set; }

        void ProduceAttack(IBlob target);
    }
}