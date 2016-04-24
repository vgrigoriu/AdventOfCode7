// <copyright file="Program.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode7
{
    /// <summary>
    /// Entry point of the program
    /// </summary>
    internal static class Program
    {
        private static void Main()
        {
            ILineParser parser = new ConstantExpressionLineParser();

            var lines = GetLinesFrom("input.txt");
            var targets = from line in lines
                          where parser.CanParse(line)
                          select parser.GetParsedExpression(line);

            foreach (var expression in targets)
            {
                Console.WriteLine(expression.GetValue());
            }
        }

        private static IEnumerable<string> GetLinesFrom(string filename)
        {
            using (var file = File.OpenText(filename))
            {
                var line = file.ReadLine();
                while (line != null)
                {
                    yield return line;
                    line = file.ReadLine();
                }
            }
        }
    }
}
