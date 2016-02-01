using System;
using Blobs.Interfaces;

namespace Blobs.IO
{
    public class ConsoleInputController : IInputController
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}