// <copyright file="AndExpression.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

namespace AdventOfCode7
{
    /// <summary>
    /// The bitwise AND of two variables
    /// </summary>
    internal class AndExpression : Expression
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndExpression"/> class.
        /// </summary>
        /// <param name="firstOperand">The first operand</param>
        /// <param name="secondOperand">The second operand</param>
        public AndExpression(Variable firstOperand, Variable secondOperand)
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

        /// <inheritdoc/>
        public override ushort GetValue()
        {
            // Obviously, this is not the correct implementation.
            return 451;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{FirstOperand} AND {SecondOperand}";
        }
    }
}
