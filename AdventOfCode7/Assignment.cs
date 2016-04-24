// <copyright file="Assignment.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

namespace AdventOfCode7
{
    /// <summary>
    /// An assignment of an expression to a variable.
    /// </summary>
    internal class Assignment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Assignment"/> class.
        /// </summary>
        /// <param name="variable">The target variable of the assignment.</param>
        /// <param name="expression">The expression assigned to the variable.</param>
        public Assignment(Variable variable, Expression expression)
        {
            Variable = variable;
            Expression = expression;
        }

        /// <summary>
        /// Gets the variable.
        /// </summary>
        public Variable Variable { get; }

        /// <summary>
        /// Gets the expression.
        /// </summary>
        public Expression Expression { get; }
    }
}
