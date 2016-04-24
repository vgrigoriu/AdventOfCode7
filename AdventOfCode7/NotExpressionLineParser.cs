// <copyright file="NotExpressionLineParser.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System.Text.RegularExpressions;

namespace AdventOfCode7
{
    /// <summary>
    /// Class that parses a line that assigns the bitwise complement of a variable to another variable ("wire"),
    /// for example:
    ///     NOT lk -> ll
    /// </summary>
    internal sealed class NotExpressionLineParser : AssignmentParser
    {
        /// <inheritdoc/>
        protected override Regex ExpressionRegex => new Regex("NOT (?<notvar>.+)");

        /// <inheritdoc/>
        protected override Expression BuildExpression(string expressionText, GroupCollection groups)
        {
            var variableText = groups["notvar"].Value;
            return new NotExpression(new Variable(variableText));
        }
    }
}
