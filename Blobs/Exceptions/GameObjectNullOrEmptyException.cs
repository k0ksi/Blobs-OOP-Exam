namespace Blobs.Exceptions
{
    public class GameObjectNullOrEmptyException : BlobsGameException
    {
        public GameObjectNullOrEmptyException(string message) 
            : base(message)
        {
        }
    }
}