using FestivalManager.Core.IO.Contracts;
using System;

namespace FestivalManager
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}