using System;

using Distributions;
using NEATCore;


namespace CPPNDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Network n = new Network(Uniform.GetInstance(), 2, 3);

            Console.WriteLine("Hello World!");
        }
    }
}
