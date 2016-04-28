// <copyright file="Environment.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode7
{
    /// <summary>
    /// A collection of all the assignments
    /// </summary>
    internal sealed class Environment
    {
        private readonly IDictionary<Variable, Expression> assignments;

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment"/> class.
        /// </summary>
        /// <param name="assignments">The list of all the assignments</param>
        public Environment(IEnumerable<Assignment> assignments)
        {
            this.assignments = assignments.ToDictionary(assignment => assignment.Variable, assignment => assignment.Expression);
        }

        /// <summary>
        /// Returns the expression assigned to the given variable.
        /// </summary>
        /// <param name="variable">The variable</param>
        /// <returns>An expression</returns>
        public Expression GetExpression(Variable variable)
        {
            return assignments[variable];
        }
    }
}
