// <copyright file="AndExpressionLineParser.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System.Text.RegularExpressions;

namespace AdventOfCode7
{
    /// <summary>
    /// For example:
    ///     af AND ah -> ai
    /// </summary>
    internal sealed class AndExpressionLineParser : AssignmentParser
    {
        /// <inheritdoc/>
        protected override Regex ExpressionRegex => new Regex("(?<firstOp>.*) AND (?<secondOp>.*)");

        /// <inheritdoc/>
        protected override Expression BuildExpression(string expressionText, GroupCollection groups)
        {
            var firstOperand = groups["firstOp"].Value;
            var secondOperand = groups["secondOp"].Value;

            return new AndExpression(new Variable(firstOperand), new Variable(secondOperand));
        }
    }
}
