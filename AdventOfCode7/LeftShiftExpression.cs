// <copyright file="LeftShiftExpression.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System;

namespace AdventOfCode7
{
    /// <summary>
    /// Left shift
    /// </summary>
    internal sealed class LeftShiftExpression : BinaryExpression
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeftShiftExpression"/> class.
        /// </summary>
        /// <param name="firstOperand">The variable</param>
        /// <param name="secondOperand">How many bits to shift</param>
        public LeftShiftExpression(Variable firstOperand, Expression secondOperand)
            : base(firstOperand, secondOperand)
        {
        }

        /// <inheritdoc/>
        /// <exception cref="NotImplementedException">Not yet.</exception>
        public override ushort GetValue()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{FirstOperand} << {SecondOperand}";
        }
    }
}
