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
        private static ILineParser[] parsers =
            {
                new ConstantExpressionLineParser(),
                new NotExpressionLineParser(),
                new AndExpressionLineParser(),
                new OrExpressionLineParser(),
                new LeftShitfExpressionLineParser(),
                new RightShitfExpressionLineParser()
            };

        private static void Main()
        {
            var lines = GetLinesFrom("input.txt");
            var assignments = from line in lines
                              from assignment in ParseLine(line)
                              select assignment;

            foreach (var assignment in assignments)
            {
                Console.WriteLine($"{assignment.Variable} = {assignment.Expression}");
            }
        }

        private static IEnumerable<Assignment> ParseLine(string line)
        {
            var matchingParser = parsers.FirstOrDefault(parser => parser.CanParse(line));

            if (matchingParser != null)
            {
                yield return matchingParser.GetAssignment(line);
            }
            else
            {
                throw new NotImplementedException($"Nobody knows how to parse: {line}");
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
