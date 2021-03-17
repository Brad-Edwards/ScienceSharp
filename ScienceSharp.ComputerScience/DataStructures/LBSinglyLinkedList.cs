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

using System;

namespace ScienceSharp.ComputerScience.DataStructures
{
    /// <summary>
    /// Represents a list-backed singly linked list.
    /// </summary>
    public class LBSinglyLinkedList<T> : ILinkedList<T>
    {
        public int Count { get; }
        public ILinkedListNode<T> First { get; }
        public bool IsEmpty { get; }
        public ILinkedListNode<T> Last { get; }
        public Type Type { get; }
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
