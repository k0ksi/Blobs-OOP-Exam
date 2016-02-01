namespace Blobs.Interfaces
{
    public interface IBehavior : IUpdateable
    {
        IBlob Blob { get; set; }

        bool IsTriggered { get; set; }

        void TriggerBehavior();

        int TurnsSinceTriggered { get; set; }
    }
}