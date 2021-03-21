// <copyright file="LBSinglyLinkedList.cs" company="Brad Edwards">
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

using ScienceSharp.Exceptions;
using System;
using System.IO;
using System.Net.Http;

namespace ScienceSharp.ComputerScience.DataStructures
{
    /// <summary>
    /// Represents a list-backed singly linked list.
    /// </summary>
    public class LbSinglyLinkedList<T> : ILinkedList<T>
    {
        /// <summary>
        /// The last <see cref="ILinkedListNode{T}"/> in the <see cref="LbSinglyLinkedList{T}"/>.
        /// </summary>
        private ILinkedListNode<T> _last;

        /// <summary>
        /// Initializes a new instance of the <see cref="LbSinglyLinkedList{T}"/> class.
        /// </summary>
        public LbSinglyLinkedList() { 

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LbSinglyLinkedList{T}"/> class with a given node at the head.
        /// </summary>
        /// <param name="node">The <see cref="ILinkedListNode{T}"/> to place at the head of the new <see cref="LbSinglyLinkedList{T}"/>.</param>
        public LbSinglyLinkedList(ILinkedListNode<T> node)
        {
            Head = node;
            Last = Head;
            Count++;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LbSinglyLinkedList{T}"/> class with a given value at the head.
        /// </summary>
        /// <param name="value">The value to put at the head of the list.</param>
        public LbSinglyLinkedList(T value)
        {
            Head = new LinkedListNode<T>(value);
            Last = Head;
            Count++;
        }

        public int Count { get; private set; }
        public ILinkedListNode<T> Head { get; private set; }
        public bool IsEmpty => Count == 0;

        public ILinkedListNode<T> Last {
            get {
                // If Last isn't set, go find the value. Seek will throw errors if the list is empty.
                return _last ?? Seek(-1);
            }
            private set {
                _last = value;
            }
        }
        public Type Type => typeof(T);

        public T this[int i] {
            get {
                var node = Seek(i);
                return node.Value;
            }
            set {
                var node = Seek(i);
                node.Value = value;
            }
        }

        public ILinkedList<T> AddAfter(ILinkedListNode<T> target, T value)
        {
            throw new NotImplementedException();
        }

        public ILinkedList<T> AddAfter(ILinkedListNode<T> target, ILinkedListNode<T> node)
        {
            throw new NotImplementedException();
        }

        public ILinkedList<T> AddBefore(ILinkedListNode<T> target, T value)
        {
            throw new NotImplementedException();
        }

        public ILinkedList<T> AddBefore(ILinkedListNode<T> target, ILinkedListNode<T> node)
        {
            throw new NotImplementedException();
        }

        public ILinkedList<T> AddFirst(T value)
        {
            throw new NotImplementedException();
        }

        public ILinkedList<T> AddFirst(ILinkedListNode<T> node)
        {
            throw new NotImplementedException();
        }

        public ILinkedList<T> Append(T value)
        {
            throw new NotImplementedException();
        }

        public ILinkedList<T> Append(ILinkedListNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }

        public ILinkedListNode<T> Find(T value)
        {
            throw new NotImplementedException();
        }

        public ILinkedListNode<T> FindLast(T value)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T value)
        {
            throw new NotImplementedException();
        }

        public bool Remove(ILinkedListNode<T> node)
        {
            throw new NotImplementedException();
        }

        public ILinkedList<T> RemoveFirst()
        {
            throw new NotImplementedException();
        }

        public ILinkedList<T> RemoveLast()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the node at a given <paramref name="index"/> in the <see cref="LbSinglyLinkedList{T}"/>.
        /// </summary>
        /// <param name="index">The index of the </param>
        /// <returns></returns>
        private ILinkedListNode<T> Seek(int index)
        {
            // Can't seek an empty list
            if (Head == null)
            {
                throw new IndexOutOfRangeException("Cannot seek in an empty list.");
            }

            // Index has to be in range.
            if (index < 0 || index > Count - 1)
            {
                throw new IndexOutOfRangeException($"Your index is out of range. List node count: {Count}");
            }

            var current = Head;
            // When index is 0, we have found the node.
            while (index > 0)
            {
                // Should never hit this if guards above work, but still.
                _ = current.Next ?? throw new IndexOutOfRangeException($"Your index is out of range. List node count: {Count}");

                current = current.Next;
                index--;
            }

            return current;
        }
    }
}
