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
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace ScienceSharp.ComputerScience.DataStructures
{
    /// <summary>
    /// Represents a list-backed singly linked list.
    /// </summary>
    public class LbSinglyLinkedList<T> : ILinkedList<T>
    {
        /// <summary>
        /// The first <see cref="ILinkedListNode{T}"/> in the <see cref="LbSinglyLinkedList{T}"/>.
        /// </summary>
        private ILinkedListNode<T> _head;

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

        public ILinkedListNode<T> Head {
            get {
                return _head;
            }
            set {
                _head = value;
            }
        }

        public bool IsEmpty => Count == 0;

        public ILinkedListNode<T> Last {
            get {
                // If Last isn't set, go find the value. Seek will throw errors if the list is empty.
                try
                {
                    return _last ?? Seek(-1);
                }
                catch (IndexOutOfRangeException ex)
                {
                    // Developer expects error from here, so wrap error from Seek
                    throw new IndexOutOfRangeException(
                        "Search went out of bounds while trying to find last node. This is probably an implementation error in LbSinglyLinkedList", ex);
                }
                
            }
            private set {
                _last = value;
            }
        }

        public Type Type => typeof(T);

        public T this[int i] {
            get {
                try
                {
                    var node = Seek(i);
                    return node.Value;
                }
                catch (IndexOutOfRangeException ex)
                {
                    // Seek will throw an error if index is out of bounds, wrap so error comes from expected source
                    throw new IndexOutOfRangeException("Your index is out of range. This is probably an implementation error in LbSinglyLinkedList.", ex);
                }
                
            }
            set {
                try
                {
                    var node = Seek(i);
                    node.Value = value;
                }
                catch (IndexOutOfRangeException ex)
                {
                    // Seek will throw an error if index is out of bounds, wrap so error comes from expected source
                    throw new IndexOutOfRangeException("Your index is out of range. This is probably an implementation error in LbSinglyLinkedList.", ex);
                }
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
            var node = new LinkedListNode<T>(value);
            AddFirst(node);
            return this;
        }

        public ILinkedList<T> AddFirst(ILinkedListNode<T> node)
        {
            node.Next = Head;
            Head = node;
            Count++;
            return this;
        }

        public ILinkedList<T> Append(T value)
        {
            var node = new LinkedListNode<T>(value);
            Append(node);
            return this;
        }

        public ILinkedList<T> Append(ILinkedListNode<T> node)
        {
            // Either the list is empty, in which case add a new node, or add it to the end of the list.
            // Last will take care of seeking if the list is not empty and Last is not set for some reason.
            if (Head == null)
            {
                Head = node;
                Last = node;
                Count = 1;
            }
            else
            {
                try
                {
                    Last.Next = node;
                    Last = Last.Next;
                    Count++;
                }
                catch (IndexOutOfRangeException e)
                {
                    // Add new error for clarity in debugging. Last will attempt to find Last and throw an error if the list is empty.
                    throw new ListEmptyException("Error when attempting to find the last node.", e);
                }
            }
            return this;
        }

        public void Clear()
        {
            Head = null;
            Last = null;
            Count = 0;
        }

        public bool Contains(T value)
        {
            if (Head is null)
            {
                return false;
            }

            var current = Head;
            while (!Equals(current.Value, value))
            {
                if (current.Next == null)
                {
                    return false;
                }

                current = current.Next;
            }

            return true;
        }

        public ILinkedListNode<T> Find(T value)
        {
            throw new NotImplementedException();
        }

        public ILinkedListNode<T> FindLast(T value)
        {
            return Last;
        }

        public bool Remove(T value)
        {
            throw new NotImplementedException();
        }

        public bool Remove(ILinkedListNode<T> node)
        {
            var results = Seek(node);
            if (results[0] is null && results[1] is null)
            {
                return false;
            }

            Head = Head.Next;

            results[0].Next = results[1].Next;
            return true;
        }

        public ILinkedList<T> RemoveFirst()
        {
            if (Head is null)
            {
                throw new ListEmptyException("Cannot remove a node from an empty list.");
            }

            var second = Head.Next;
            Head = second;
            Count--;
            return this;
        }

        public ILinkedList<T> RemoveLast()
        {
            if (Head == null) // TODO: Add exceptions to interface 
            {
                throw new ListEmptyException("Cannot remove a node from an empty list.");
            }

            // Seek will work fine if there's at least 2 nodes
            if (Head.Next == null)
            {
                Head = null;
            }
            else
            {
                var newLast = Seek(-2);
                newLast.Next = null;
                Last = newLast;
            }

            Count--;
            return this;
        }

        /// <summary>
        /// Finds the node at a given <paramref name="index"/> in the <see cref="LbSinglyLinkedList{T}"/>.
        /// </summary>
        /// <param name="index">The index of the </param>
        /// <exception cref="IndexOutOfRangeException">Thrown when the index is out of range or the <see cref="LbSinglyLinkedList{T}"/> is empty.</exception>
        /// <returns><see cref="ILinkedListNode{T}"/><para>The node at the ith position.</para></returns>
        private ILinkedListNode<T> Seek(int index)
        {
            // Can't seek in an empty list
            if (Head == null)
            {
                throw new IndexOutOfRangeException("Cannot seek in an empty list.");
            }
            
            // Convert reverse index into standard index.
            // Since list is 0 indexed, the standard -1 for last element is just Count - 1
            // Add, since index is negative
            if (index < 0)
            {
                index += Count;
            }
            
            // Index has to be in range.
            if (index < 0 || index > Count - 1)
            {
                throw new IndexOutOfRangeException($"Your index is out of range. List node count: {Count}. Index: {index}");
            }

            if (index == 0)
            {
                return Head;
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

        private ILinkedListNode<T>[] Seek(ILinkedListNode<T> targetNode)
        {
            var results = new ILinkedListNode<T>[2];
            if (Head is null)
            {
                return results;
            }

            if (Head == targetNode)
            {
                results[1] = Head;
                return results;
            }

            var prev = Head;
            var current = Head.Next;
            while (current is not null)
            {
                if (current == targetNode)
                {
                    results[0] = prev;
                    results[1] = current;
                    return results;
                }

                prev = current;
                current = prev.Next;
            }

            return results;
        }

        /// <summary>
        /// Finds the first <see cref="ILinkedListNode{T}"/> containing 
        /// </summary>
        /// <param name="targetValue"></param>
        /// <returns></returns>
        private ILinkedListNode<T> Seek(T targetValue)
        {
            throw new NotImplementedException();
        }
    }
}
