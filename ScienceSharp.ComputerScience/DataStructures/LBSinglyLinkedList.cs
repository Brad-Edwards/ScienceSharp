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
using System.Net.Http;

namespace ScienceSharp.ComputerScience.DataStructures
{
    /// <summary>
    /// Represents a list-backed singly linked list.
    /// </summary>
    public class LbSinglyLinkedList<T> : ILinkedList<T>
    {
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

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LbSinglyLinkedList{T}"/> class with a given value at the head.
        /// </summary>
        /// <param name="value">The value to put at the head of the list.</param>
        public LbSinglyLinkedList(T value)
        {

        }
        public int Count { get; private set; }
        public ILinkedListNode<T> Head { get; private set; }
        public bool IsEmpty { get; private set; }
        public ILinkedListNode<T> Last { get; private set; }
        public Type Type => typeof(T);

        public T this[int i] {
            get {
                if (i < 0 || i > Count - 1)
                {
                    throw new IndexOutOfRangeException();
                }

                var current = Head;
                for (var j = 0; j < i; j++)
                {
                    current = current.Next;
                }
                return current.Value;
            }
            set {
                if (i < 0 || i > Count - 1)
                {
                    throw new IndexOutOfRangeException();
                }

                var current = Head;
                for (var j = 0; j < i; j++)
                {
                    current = current.Next;
                }

                current.Value = value;
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
    }
}
