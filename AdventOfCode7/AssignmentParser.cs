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
        /// <summary>
        /// Gets a regex that must match the expression partof the assignment.
        /// </summary>
        protected abstract Regex ExpressionRegex { get; }

        /// <inheritdoc/>
        public bool CanParse(string line)
        {
            return AssignmentRegex().IsMatch(line);
        }

        /// <inheritdoc/>
        public Assignment GetAssignment(string line)
        {
            var match = AssignmentRegex().Match(line);
            var expressionText = match.Groups["exp"].Value;
            var variableName = match.Groups["var"].Value;

            return new Assignment(
                new Variable(variableName),
                BuildExpression(expressionText, match.Groups));
        }

        /// <summary>
        /// Must be overridden in derived classes to build the expression out of the
        /// expression text given.
        /// </summary>
        /// <param name="expressionText">The text representation of the expression.</param>
        /// <param name="groups">The groups created by matching the regular expression agains the line.</param>
        /// <returns>An expression.</returns>
        protected abstract Expression BuildExpression(string expressionText, GroupCollection groups);

        private Regex AssignmentRegex() => new Regex($@"(?<exp>{ExpressionRegex}) -> (?<var>.*)");
    }
}
