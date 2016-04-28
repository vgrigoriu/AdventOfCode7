// <copyright file="OrExpression.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System;

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
        public OrExpression(Expression firstOperand, Expression secondOperand)
            : base(firstOperand, secondOperand)
        {
        }

        /// <inheritdoc/>
        public override ushort GetValue(Environment environment)
        {
            Console.WriteLine($"Evaluating {this}");
            var leftSide = FirstOperand.GetValue(environment);
            var rightSide = SecondOperand.GetValue(environment);

            return (ushort)(leftSide | rightSide);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{FirstOperand} OR {SecondOperand}";
        }
    }
}
