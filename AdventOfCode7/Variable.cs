// <copyright file="Variable.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System;

namespace AdventOfCode7
{
    /// <summary>
    /// A variable.
    /// </summary>
    internal class Variable : Expression
    {
        private readonly string name;
        private ushort? value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Variable"/> class.
        /// The variable will have the given name.
        /// </summary>
        /// <param name="name">The name of the variable.</param>
        public Variable(string name)
        {
            this.name = name;
        }

        /// <inheritdoc/>
        public override ushort GetValue(Environment environment)
        {
            Console.WriteLine($"Evaluating {this}");

            if (!value.HasValue)
            {
                var expression = environment.GetExpression(this);

                value = expression.GetValue(environment);
            }

            return value.Value;
        }

        /// <summary>
        /// Returns the name of the variable.
        /// </summary>
        /// <returns>The name of the variable.</returns>
        public override string ToString()
        {
            return name;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return name.Equals((obj as Variable)?.name);
        }
    }
}
