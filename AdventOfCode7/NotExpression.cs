// <copyright file="NotExpression.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System;

namespace AdventOfCode7
{
    /// <summary>
    /// The negation of a variable.
    /// </summary>
    internal class NotExpression : Expression
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotExpression"/> class.
        /// </summary>
        /// <param name="negatedVariable">The variable whose bitwise complement we take.</param>
        public NotExpression(Variable negatedVariable)
        {
            NegatedVariable = negatedVariable;
        }

        /// <summary>
        /// Gets the variable to negate.
        /// </summary>
        public Variable NegatedVariable { get; }

        /// <inheritdoc/>
        public override ushort GetValue(Environment environment)
        {
            Console.WriteLine($"Evaluating {this}");
            return (ushort)~NegatedVariable.GetValue(environment);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"NOT {NegatedVariable}";
        }
    }
}
