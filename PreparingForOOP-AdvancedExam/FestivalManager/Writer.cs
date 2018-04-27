using FestivalManager.Core.IO.Contracts;
using System;

namespace FestivalManager
{
    internal class Writer : IWriter
    {
        public void Write(string contents)
        {
            Console.Write(contents);
        }

        public void WriteLine(string contents)
        {
            Console.WriteLine(contents);
        }
    }
}