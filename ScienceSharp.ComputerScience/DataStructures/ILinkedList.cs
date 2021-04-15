// <copyright file="ILinkedList.cs" company="Brad Edwards">
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
{ // TODO: Add throws comments to each method
    /// <summary>
    /// Defines methods for manipulating a linked list.
    /// </summary>
    public interface ILinkedList<T>
    {
        /// <summary>
        /// The number of nodes in the <see cref="ILinkedList{T}"/>.
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// The first node in the <see cref="ILinkedList{T}"/>.
        /// </summary>
        public ILinkedListNode<T> Head { get; }

        /// <summary>
        /// Indicates whether the <see cref="ILinkedList{T}"/> is empty.
        /// </summary>
        public bool IsEmpty { get; }

        /// <summary>
        /// The last node in the <see cref="ILinkedList{T}"/>.
        /// </summary>
        public ILinkedListNode<T> Last { get; }

        /// <summary>
        /// The <see cref="System.Type"/> of the values in the <see cref="ILinkedList{T}"/>.
        /// </summary>
        public Type Type { get; }

        /// <summary>
        /// Returns the value of the ith node of the <see cref="ILinkedList{T}"/>.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T this[int i] { get; set; }
        
        /// <summary>
        /// Adds <paramref name="value"/> to the <see cref="ILinkedList{T}"/> after <paramref name="target"/>.
        /// </summary>
        /// <param name="target">The node that should precede <paramref name="value"/> in the modified <see cref="ILinkedList{T}"/>.</param>
        /// <param name="value">The value to add to the <see cref="ILinkedList{T}"/> after <paramref name="target"/>.</param>
        /// <returns><see cref="ILinkedList{T}"/><para>The <see cref="ILinkedList{T}"/> after adding <paramref name="value"/>.</para>
        /// </returns>
        public ILinkedList<T> AddAfter(ILinkedListNode<T> target, T value);

        /// <summary>
        /// Adds <paramref name="node"/> to the <see cref="ILinkedList{T}"/> after <paramref name="target"/>.
        /// </summary>
        /// <param name="target">The node that should precede <paramref name="node"/> in the modified <see cref="ILinkedList{T}"/>.</param>
        /// <param name="node">The node to add to the <see cref="ILinkedList{T}"/> after <paramref name="target"/>.</param>
        /// <returns><see cref="ILinkedList{T}"/><para>The <see cref="ILinkedList{T}"/> after adding <paramref name="node"/>.</para></returns>
        public ILinkedList<T> AddAfter(ILinkedListNode<T> target, ILinkedListNode<T> node);

        /// <summary>
        /// Adds <paramref name="value"/> to the <see cref="ILinkedList{T}"/> before <paramref name="target"/>.
        /// </summary>
        /// <param name="target">The node that should come after <paramref name="value"/>.</param>
        /// <param name="value">The value to add to the <see cref="ILinkedList{T}"/> before <paramref name="target"/>.</param>
        /// <returns><see cref="ILinkedList{T}"/><para>The <see cref="ILinkedList{T}"/> after adding <paramref name="value"/>.</para></returns>
        public ILinkedList<T> AddBefore(ILinkedListNode<T> target, T value);

        /// <summary>
        /// Adds <paramref name="node"/> to the <see cref="ILinkedList{T}"/> before <paramref name="target"/>.
        /// </summary>
        /// <param name="target">The node that should come after <paramref name="node"/>.</param>
        /// <param name="node">The node to add to the <see cref="ILinkedList{T}"/> before <paramref name="target"/>.</param>
        /// <returns><see cref="ILinkedList{T}"/><para>The <see cref="ILinkedList{T}"/> after adding <paramref name="node"/>.</para></returns>
        public ILinkedList<T> AddBefore(ILinkedListNode<T> target, ILinkedListNode<T> node);

        /// <summary>
        /// Adds <paramref name="value"/> to the start of the <see cref="ILinkedList{T}"/>.
        /// </summary>
        /// <param name="value">The value to add to the <see cref="ILinkedList{T}"/>.</param>
        /// <returns><see cref="ILinkedList{T}"/><para>The <see cref="ILinkedList{T}"/> after adding <paramref name="value"/>.</para></returns>
        public ILinkedList<T> AddFirst(T value);

        /// <summary>
        /// Adds <paramref name="node"/> to the start of the <see cref="ILinkedList{T}"/>.
        /// </summary>
        /// <param name="node">The node to add to the <see cref="ILinkedList{T}"/>.</param>
        /// <returns><see cref="ILinkedList{T}"/><para>The <see cref="ILinkedList{T}"/> after adding <paramref name="node"/>.</para></returns>
        public ILinkedList<T> AddFirst(ILinkedListNode<T> node);

        /// <summary>
        /// Adds <paramref name="value"/> to the end of the <see cref="ILinkedList{T}"/>.
        /// </summary>
        /// <param name="value">The value to add to the end of the <see cref="ILinkedList{T}"/>.</param>
        /// <returns><see cref="ILinkedList{T}"/><para>The <see cref="ILinkedList{T}"/> after adding <paramref name="value"/>.</para></returns>
        public ILinkedList<T> Append(T value);

        /// <summary>
        /// Adds <paramref name="node"/> to the end of the <see cref="ILinkedList{T}"/>.
        /// </summary>
        /// <param name="node">The value to add to the end of the <see cref="ILinkedList{T}"/>.</param>
        /// <returns><see cref="ILinkedList{T}"/><para>The <see cref="ILinkedList{T}"/> after adding <paramref name="node"/>.</para></returns>
        public ILinkedList<T> Append(ILinkedListNode<T> node);

        /// <summary>
        /// Empties the <see cref="LbSinglyLinkedList{T}"/>.
        /// </summary>
        public void Clear();

        /// <summary>
        /// Determines whether <paramref name="value"/> is in the <see cref="ILinkedList{T}"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <returns><see cref="Boolean"/><para><value>true</value> if <paramref name="value"/> is contained in the <see cref="ILinkedList{T}"/>, otherwise <value>false</value>.</para></returns>
        public bool Contains(T value);

        /// <summary>
        /// Finds the first <see cref="ILinkedListNode{T}"/> that contains <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value to locate in the <see cref="ILinkedList{T}"/>.</param>
        /// <returns><see cref="ILinkedListNode{T}"/><para>The first <see cref="ILinkedListNode{T}"/> that contains <paramref name="value"/>, or <value>null</value> if <paramref name="value"/> could not be found.</para></returns>
        public ILinkedListNode<T> Find(T value);

        /// <summary>
        /// Finds the last <see cref="ILinkedListNode{T}"/> that contains <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value to locate in the <see cref="ILinkedList{T}"/>.</param>
        /// <returns><see cref="ILinkedListNode{T}"/><br/><para>The last node that contains <paramref name="value"/>, or <value>null</value> if <paramref name="value"/> could not be found.</para></returns>
        public ILinkedListNode<T> FindLast(T value);

        /// <summary>
        /// Finds the <see cref="ILinkedListNode{T}"/> in the <see cref="LbSinglyLinkedList{T}"/> at <paramref name="index"/>.
        /// </summary>
        /// <param name="index">The index of the <see cref="ILinkedListNode{T}"/> to find.</param>
        /// <returns><see cref="ILinkedListNode{T}"/><para>The <see cref="ILinkedListNode{T}"/> at <paramref name="index"/></para></returns>
        public ILinkedListNode<T> NodeAt(int index);

        /// <summary>
        /// Removes the first <see cref="ILinkedListNode{T}"/> containing <paramref name="value"/> from the <see cref="ILinkedList{T}"/>.
        /// </summary>
        /// <param name="value">The value to remove from the <see cref="ILinkedList{T}"/></param>
        /// <returns><see cref="bool"/><para><value>true</value> if <paramref name="value"/> was found and removed, otherwise <value>false</value>.</para></returns>
        public bool Remove(T value);

        /// <summary>
        /// Removes <paramref name="node"/> from the <see cref="ILinkedList{T}"/>.
        /// </summary>
        /// <param name="node">The <see cref="ILinkedListNode{T}"/> to remove from the <see cref="ILinkedList{T}"/></param>
        /// <returns><see cref="bool"/><para><value>true</value> if <paramref name="node"/> was found and removed, otherwise <value>false</value>.</para></returns>
        public bool Remove(ILinkedListNode<T> node);

        /// <summary>
        /// Removes the first <see cref="ILinkedListNode{T}"/> from the <see cref="ILinkedList{T}"/>.
        /// </summary>
        /// <returns><see cref="ILinkedList{T}"/><para>The <see cref="ILinkedList{T}"/> with the first <seealso cref="ILinkedListNode{T}"/> removed.</para></returns>
        public ILinkedList<T> RemoveFirst();

        /// <summary>
        /// Removes the last <see cref="ILinkedListNode{T}"/> from the <see cref="ILinkedList{T}"/>.
        /// </summary>
        /// <returns><see cref="ILinkedList{T}"/><para>The <see cref="ILinkedList{T}"/> with the last <see cref="ILinkedListNode{T}"/> removed.</para> </returns>
        public ILinkedList<T> RemoveLast();
    }
}
