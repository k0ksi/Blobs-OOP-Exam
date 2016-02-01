namespace Blobs.Exceptions
{
    public class BlobsGameException : GameException
    {
        public BlobsGameException(string message) 
            : base(message)
        {
        }
    }
}