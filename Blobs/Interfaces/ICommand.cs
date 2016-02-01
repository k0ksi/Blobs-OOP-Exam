namespace Blobs.Interfaces
{
    public interface ICommand
    {
        IEngine Engine { get; }

        void Execute(params string[] commandParams);
    }
}