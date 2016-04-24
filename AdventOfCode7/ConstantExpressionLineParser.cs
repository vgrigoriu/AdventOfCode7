// <copyright file="ConstantExpressionLineParser.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System;
using System.Text.RegularExpressions;

namespace AdventOfCode7
{
    /// <summary>
    /// Class that parses a line that assigns a constant expression to a variable ("wire"),
    /// for example:
    ///     14146 -> b
    /// </summary>
    internal sealed class ConstantExpressionLineParser : ILineParser
    {
        private static readonly Regex ConstantExpressionLineRegex = new Regex(@"(\d+) -> (.*)");

        /// <inheritdoc/>
        public bool CanParse(string line)
        {
            return ConstantExpressionLineRegex.IsMatch(line);
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentException">
        /// The given line cannot be parsed as a constant expression assignment.
        /// </exception>
        public Assignment GetAssignment(string line)
        {
            var match = ConstantExpressionLineRegex.Match(line);
            var expressionText = match.Groups[1].Value;
            var variableName = match.Groups[2].Value;

            return new Assignment(
                new Variable(variableName),
                BuildExpression(expressionText));
        }

        private Expression BuildExpression(string expressionText)
        {
            ushort value;
            if (ushort.TryParse(expressionText, out value))
            {
                return new ConstantExpression(value);
            }

            throw new ArgumentException($"Cannot parse input as constant expression: {expressionText}", nameof(expressionText));
        }
    }
}
