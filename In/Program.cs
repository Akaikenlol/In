using System;
using System.IO;

namespace In
{
    class Program
    {
        public static void Main(string[] args)
        {
            TextReader tIn = Console.In;
            TextWriter tOut = Console.Out;

            tOut.WriteLine("Keith");
            tOut.Write("What is your Name:");
            string name = tIn.ReadLine();

            tOut.WriteLine("Keith,{4}!",name);
        }
    }
}
