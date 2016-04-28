// <copyright file="ConstantExpression.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System;

namespace AdventOfCode7
{
    /// <summary>
    /// Represents a constant expression, such as 7.
    /// </summary>
    internal sealed class ConstantExpression : Expression
    {
        private readonly ushort value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantExpression"/> class.
        /// </summary>
        /// <param name="value">The value of this constant expression.</param>
        public ConstantExpression(ushort value)
        {
            this.value = value;
        }

        /// <inheritdoc/>
        public override ushort GetValue(Environment environment)
        {
            Console.WriteLine($"Evaluating {this}");

            return value;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return value.ToString();
        }
    }
}
