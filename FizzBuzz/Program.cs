﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Fizz fizz = new Fizz();
            fizz.Buzz();
            Console.ReadKey();
        }
    }
}
