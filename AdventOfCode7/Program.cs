﻿using System;
using System.IO;

namespace AdventOfCode7
{
    class Program
    {
        static void Main()
        {
            using (var file = File.OpenText("input.txt"))
            {
                var firstLine = file.ReadLine();
                Console.WriteLine($">{firstLine}<");
            }
        }
    }
}