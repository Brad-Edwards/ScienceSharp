// <copyright file="LinkedListNode.cs" company="Brad Edwards">
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

namespace ScienceSharp.ComputerScience.DataStructures
{
    /// <summary>
    /// Represents a node in a linked list.
    /// </summary>
    /// <typeparam name="T">The underlying type of the <see cref="LinkedListNode{T}"/></typeparam>
    public class LinkedListNode<T> : ILinkedListNode<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListNode{T}"/> class.
        /// </summary>
        public LinkedListNode()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListNode{T}"/> class with a value.
        /// </summary>
        /// <param name="value">The value to use for initializing the <see cref="LinkedListNode{T}"/></param>
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public Type ValueType => typeof(T);
        public ILinkedListNode<T> Next { get; set; }
        public ILinkedListNode<T> Previous { get; set; }
    }
}
