﻿// <copyright file="ConstantExpressionLineParser.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System;

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
        /// Given a string of digits, return a ConstantExpression whose value
        /// in base 10 is that string of digits.
        /// </summary>
        /// <param name="expressionText">The string of digits to parse.</param>
        /// <returns>A constant expression.</returns>
        /// <exception cref="ArgumentException">The given text cannot be parsed as an unsigned short.</exception>
        protected override Expression BuildExpression(string expressionText)
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
