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
        /// <exception cref="NotImplementedException">
        /// Not yet. This needs to be modified to take an environment -- list of variables
        /// </exception>
        public override ushort GetValue()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the name of the variable.
        /// </summary>
        /// <returns>The name of the variable.</returns>
        public override string ToString()
        {
            return name;
        }
    }
}
