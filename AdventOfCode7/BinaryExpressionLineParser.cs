// <copyright file="BinaryExpressionLineParser.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System.Text.RegularExpressions;

namespace AdventOfCode7
{
    /// <summary>
    /// Abstract base class for parsers of binary expressions
    /// </summary>
    internal abstract class BinaryExpressionLineParser : AssignmentParser
    {
        /// <inheritdoc/>
        protected override sealed Regex ExpressionRegex => new Regex($"(?<firstOp>.*) {OperatorName} (?<secondOp>.*)");

        /// <summary>
        /// Gets the name of the operator; must be implemented by derived classes
        /// </summary>
        protected abstract string OperatorName { get; }

        /// <inheritdoc/>
        protected override sealed Expression BuildExpression(string expressionText, GroupCollection groups)
        {
            var firstOperand = groups["firstOp"].Value;
            var secondOperand = groups["secondOp"].Value;

            return BuildExpression(new Variable(firstOperand), new Variable(secondOperand));
        }

        /// <summary>
        /// Must be implemented by derived classes to build the actual expression they return
        /// </summary>
        /// <param name="firstOperand">The first operand</param>
        /// <param name="secondOperand">The second operand</param>
        /// <returns>A binary expression</returns>
        protected abstract BinaryExpression BuildExpression(Variable firstOperand, Variable secondOperand);
    }
}
