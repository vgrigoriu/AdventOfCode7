// <copyright file="LeftShitfExpressionLineParser.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System;

namespace AdventOfCode7
{
    /// <summary>
    /// For example:
    ///     eo LSHIFT 15 -> es
    /// </summary>
    internal sealed class LeftShitfExpressionLineParser : BinaryExpressionLineParser
    {
        /// <inheritdoc/>
        protected override string OperatorName => "LSHIFT";

        /// <inheritdoc/>
        protected override BinaryExpression BuildExpression(Variable firstOperand, Expression secondOperand)
        {
            return new LeftShiftExpression(firstOperand, secondOperand);
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentException">Thrown if secondOperandText is not a constant.</exception>
        protected override Expression BuildSecondOperand(string secondOperandText)
        {
            ushort value;
            if (ushort.TryParse(secondOperandText, out value))
            {
                return new ConstantExpression(value);
            }

            throw new ArgumentException($"Cannot parse input as constant expression: {secondOperandText}", nameof(secondOperandText));
        }
    }
}
