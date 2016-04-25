// <copyright file="BinaryExpression.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

namespace AdventOfCode7
{
    /// <summary>
    /// Abstract base class for building binary expressions
    /// </summary>
    internal abstract class BinaryExpression : Expression
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryExpression"/> class.
        /// </summary>
        /// <param name="firstOperand">The first operand</param>
        /// <param name="secondOperand">The second operand</param>
        protected BinaryExpression(Variable firstOperand, Variable secondOperand)
        {
            FirstOperand = firstOperand;
            SecondOperand = secondOperand;
        }

        /// <summary>
        /// Gets the first operand
        /// </summary>
        public Variable FirstOperand { get; }

        /// <summary>
        /// Gets the second operand
        /// </summary>
        public Variable SecondOperand { get; }

        /// <summary>
        /// Deriving classes must implement ToString()
        /// </summary>
        /// <returns>A string representation of the expression</returns>
        public abstract override string ToString();
    }
}
