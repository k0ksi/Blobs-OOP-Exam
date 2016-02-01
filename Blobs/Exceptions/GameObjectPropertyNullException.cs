namespace Blobs.Exceptions
{
    public class GameObjectPropertyNullException : BlobsGameException
    {
        public GameObjectPropertyNullException(string message) 
            : base(message)
        {
        }
    }
}