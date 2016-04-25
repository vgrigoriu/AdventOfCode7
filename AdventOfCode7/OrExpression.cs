// <copyright file="OrExpression.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

namespace AdventOfCode7
{
    /// <summary>
    /// The bitwise OR of two variables
    /// </summary>
    internal sealed class OrExpression : BinaryExpression
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrExpression"/> class.
        /// </summary>
        /// <param name="firstOperand">The first operand</param>
        /// <param name="secondOperand">The second operand</param>
        public OrExpression(Variable firstOperand, Variable secondOperand)
            : base(firstOperand, secondOperand)
        {
        }

        /// <inheritdoc/>
        public override ushort GetValue()
        {
            // Obviously, this is not the correct implementation.
            return 123;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{FirstOperand} OR {SecondOperand}";
        }
    }
}
