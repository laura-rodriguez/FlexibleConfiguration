﻿// <copyright file="ParseException.cs" company="Nate Barbettini">
// Copyright (c) Nate Barbettini. All rights reserved.
// </copyright>

using System;

namespace FlexibleConfiguration
{
    /// <summary>
    /// Represents an error that occurs when parsing a configuration source.
    /// </summary>
    [Serializable]
    public sealed class ParseException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseException"/> class
        /// with a specified error message.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        /// <param name="innerException">The inner exception, if any.</param>
        public ParseException(string message, Exception innerException = null)
            : base(message, innerException)
        {
        }
    }
}
