namespace Blobs.Exceptions
{
    public class GameObjectPropertyOutOfRangeException : BlobsGameException
    {
        public GameObjectPropertyOutOfRangeException(string message) 
            : base(message)
        {
        }
    }
}