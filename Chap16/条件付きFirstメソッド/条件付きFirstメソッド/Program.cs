﻿using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 4649, 8823, 4989 };
        Console.WriteLine(array.First(c => c % 10 == 3));
    }
}
