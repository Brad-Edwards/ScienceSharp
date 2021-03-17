// <copyright file="LanguageNotSetException.cs" company="Brad Edwards">
//
// Copyright (c) 2021 Brad Edwards
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR
// OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.</copyright>

using System;

namespace ScienceSharp.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a language is not set where this is required.
    /// </summary>
    public class LanguageNotSetException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageNotSetException"/> class.
        /// </summary>
        public LanguageNotSetException()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageNotSetException"/> class with an error message.
        /// </summary>
        /// <param name="message"></param>
        public LanguageNotSetException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageNotSetException"/> class with an error message and inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public LanguageNotSetException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}