namespace Blobs.Exceptions
{
    public class BehaviorNotImplementedException : BlobsGameException
    {
        public BehaviorNotImplementedException(string message) 
            : base(message)
        {
        }
    }
}