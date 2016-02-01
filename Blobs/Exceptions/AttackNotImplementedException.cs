namespace Blobs.Exceptions
{
    public class AttackNotImplementedException : BlobsGameException
    {
        public AttackNotImplementedException(string message) 
            : base(message)
        {
        }
    }
}