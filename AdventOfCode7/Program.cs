using System;
using System.IO;
using System.Text.RegularExpressions;

namespace AdventOfCode7
{
    class Program
    {
        static void Main()
        {
            using (var file = File.OpenText("input.txt"))
            {
                var line = file.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(ExtractTargetFrom(line));
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
