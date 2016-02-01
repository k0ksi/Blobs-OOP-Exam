namespace Blobs.Interfaces
{
    public interface IRenderer
    {
        void Print(string message, params object[] parameters);
    }
}