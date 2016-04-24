// <copyright file="AssignmentParser.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System.Text.RegularExpressions;

namespace AdventOfCode7
{
    /// <summary>
    /// Abstract class that implements the base logic to parse an assignment:
    /// get the variable and the expression text. Derived classes must parse
    /// the expression text to return an expression.
    /// </summary>
    internal abstract class AssignmentParser : ILineParser
    {
        private static readonly Regex ConstantExpressionLineRegex = new Regex(@"(\d+) -> (.*)");

        /// <inheritdoc/>
        public bool CanParse(string line)
        {
            return ConstantExpressionLineRegex.IsMatch(line);
        }

        /// <inheritdoc/>
        public Assignment GetAssignment(string line)
        {
            var match = ConstantExpressionLineRegex.Match(line);
            var expressionText = match.Groups[1].Value;
            var variableName = match.Groups[2].Value;

            return new Assignment(
                new Variable(variableName),
                BuildExpression(expressionText));
        }

        /// <summary>
        /// Must be overridden in derived classes to build the expression out of the
        /// expression text given.
        /// </summary>
        /// <param name="expressionText">The text representation of the expression.</param>
        /// <returns>An expression.</returns>
        protected abstract Expression BuildExpression(string expressionText);
    }
}
