using System;

namespace Blobs.Exceptions
{
    public class GameException : Exception
    {
        public GameException(string message)
            : base(message)
        {
        }
    }
}