// <copyright file="Expression.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

namespace AdventOfCode7
{
    /// <summary>
    /// The base class for expressions that can be assigned to variables ("wires")
    /// </summary>
    internal abstract class Expression
    {
        /// <summary>
        /// Return the value of this expression.
        /// </summary>
        /// <returns>The value of this expression.</returns>
        public abstract ushort GetValue();
    }
}
