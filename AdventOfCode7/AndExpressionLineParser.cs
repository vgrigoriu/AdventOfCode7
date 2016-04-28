// <copyright file="AndExpressionLineParser.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

namespace AdventOfCode7
{
    /// <summary>
    /// For example:
    ///     af AND ah -> ai
    /// </summary>
    internal sealed class AndExpressionLineParser : BinaryExpressionLineParser
    {
        /// <inheritdoc/>
        protected override string OperatorName => "AND";

        /// <inheritdoc/>
        protected override BinaryExpression BuildExpression(Expression firstOperand, Expression secondOperand)
        {
            return new AndExpression(firstOperand, secondOperand);
        }
    }
}
