using System;
using Blobs.Interfaces;

namespace Blobs.IO
{
    public class ConsoleRenderer : IRenderer
    {
        public void Print(string message, params object[] parameters)
        {
            Console.Write(message, parameters);
        }
    }
}