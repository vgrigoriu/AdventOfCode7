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
    internal sealed class ConstantExpressionLineParser : AssignmentParser
    {
        /// <summary>
        /// Gets aregular expression that matches one or more digits.
        /// </summary>
        protected override Regex ExpressionRegex => new Regex(@"\d+");

        /// <summary>
        /// Given a string of digits, return a ConstantExpression whose value
        /// in base 10 is that string of digits.
        /// </summary>
        /// <param name="expressionText">The string of digits to parse.</param>
        /// <param name="groups">This parameter is ignored here.</param>
        /// <returns>A constant expression.</returns>
        /// <exception cref="ArgumentException">The given text cannot be parsed as an unsigned short.</exception>
        protected override Expression BuildExpression(string expressionText, GroupCollection groups)
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
