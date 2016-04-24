// <copyright file="ILineParser.cs" company="Victor Grigoriu (vgrigoriu@gmail.com)">
// Copyright (c) Victor Grigoriu (vgrigoriu@gmail.com). All rights reserved.
// </copyright>

namespace AdventOfCode7
{
    /// <summary>
    /// Interface for classes that can parse input lines.
    /// </summary>
    internal interface ILineParser
    {
        /// <summary>
        /// Returns true if the class can parse the given line.
        /// </summary>
        /// <param name="line">The line to parse.</param>
        /// <returns>True if the class can parse the given line.</returns>
        bool CanParse(string line);

        /// <summary>
        /// Returns the <see cref="Expression" /> parsed from the given line.
        /// </summary>
        /// <param name="line">The line to parse.</param>
        /// <returns>The <see cref="Expression" /> parsed from the given line.</returns>
        Expression GetParsedExpression(string line);
    }
}
