﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            Console.WriteLine(rnd.Next(7));
            Console.Read();

        }
    }
}
