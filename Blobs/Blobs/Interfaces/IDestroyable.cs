namespace Blobs.Interfaces
{
    public interface IDestroyable
    {
        int Health { get; set; }

        bool IsAlive { get; }
    }
}