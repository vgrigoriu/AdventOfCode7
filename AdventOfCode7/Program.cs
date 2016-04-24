// <copyright file="Program.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode7
{
    /// <summary>
    /// Entry point of the program
    /// </summary>
    internal static class Program
    {
        private static void Main()
        {
            var lines = GetLinesFrom("input.txt");
            var targets = lines.Select(ExtractTargetFrom).ToList();

            Trace.Assert(targets.Count == targets.Distinct().Count(), "targets are not unique");
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

        private static string ExtractTargetFrom(string line)
        {
            var regex = new Regex(".* -> (.*)");
            var match = regex.Match(line);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            throw new ArgumentException("Does not match expected format expr -> var", nameof(line));
        }
    }
}
