// <copyright file="Variable.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

namespace AdventOfCode7
{
    /// <summary>
    /// A variable.
    /// </summary>
    internal class Variable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Variable"/> class.
        /// The variable will have the given name.
        /// </summary>
        /// <param name="name">The name of the variable.</param>
        public Variable(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Gets the name of the variable.
        /// </summary>
        public string Name { get; }
    }
}
