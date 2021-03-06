﻿// <copyright file="OrExpressionLineParser.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

namespace AdventOfCode7
{
    /// <summary>
    /// For example:
    ///     af OR ah -> ai
    /// </summary>
    internal sealed class OrExpressionLineParser : BinaryExpressionLineParser
    {
        /// <inheritdoc/>
        protected override string OperatorName => "OR";

        /// <inheritdoc/>
        protected override BinaryExpression BuildExpression(Expression firstOperand, Expression secondOperand)
        {
            return new OrExpression(firstOperand, secondOperand);
        }
    }
}
