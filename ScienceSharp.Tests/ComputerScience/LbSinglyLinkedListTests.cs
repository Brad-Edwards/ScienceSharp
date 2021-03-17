// <copyright file="Program.cs" company="Brad Edwards">
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

using System.Runtime.InteropServices;
using NUnit.Framework;
using ScienceSharp.ComputerScience.DataStructures;
using ScienceSharp.Utilities.Data;

namespace ScienceSharp.Tests.ComputerScience
{
    /// <summary>
    /// Represents tests for the <see cref="LbSinglyLinkedList{T}"/> class.
    /// </summary>
    [TestFixture]
    [TestOf(typeof(LbSinglyLinkedList<>))]
    public class LbSinglyLinkedListTests
    {
        /// <summary>
        /// A random value generator.
        /// </summary>
        private ValueGenerator _generator;

        /// <summary>
        /// Performs setup for <see cref="LbSinglyLinkedList{T}"/> unit tests.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _generator = new ValueGenerator();
        }

        /// <summary>
        /// Tests that the <see cref="LbSinglyLinkedList{T}"/> accurately tracks the number of <see cref="ILinkedListNode{T}"/> instances in the list.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void ReturnsRightNodeCount()
        {
            var list = new LbSinglyLinkedList<int>();
            Assert.AreEqual(list.Count, 0);
            list.Append(new LinkedListNode<int>());
            list.Append(4);
            list.Append(new LinkedListNode<int>());
            Assert.AreEqual(list.Count, 3);
            list.RemoveLast();
            Assert.AreEqual(list.Count, 2);
            list.RemoveFirst();
            Assert.AreEqual(list.Count, 1);
            list.Clear();
            Assert.AreEqual(list.Count, 0);
        }

        /// <summary>
        /// Tests that the <see cref="LbSinglyLinkedList{T}"/> accurately returns the first node in the list.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void ReturnsCorrectFirstNode()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var second = new LinkedListNode<int>();
            Assert.IsNull(list.First);
            list.Append(first);
            list.Append(second);
            Assert.AreSame(list.First, first);
            list.RemoveFirst();
            Assert.AreSame(list.First, second);
            list.Clear();
            Assert.IsNull(list.First);
        }

        /// <summary>
        /// Tests that the <see cref="LbSinglyLinkedList{T}"/> accurately reports when it is empty.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void ReturnsAccurateIsEmptyValue()
        {
            var list = new LbSinglyLinkedList<int>();
            Assert.True(list.IsEmpty);
            list.Append(new LinkedListNode<int>());
            Assert.False(list.IsEmpty);
            list.Clear();
            Assert.True(list.IsEmpty);
        }

        /// <summary>
        /// Tests that the <see cref="LbSinglyLinkedList{T}"/> accurately returns the last node in the list.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void ReturnsCorrectLastNode()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var second = new LinkedListNode<int>();
            var third = new LinkedListNode<int>();
            list.Append(first);
            Assert.AreSame(list.Last, first);
            list.Append(second);
            Assert.AreSame(list.Last, second);
            list.Append(third);
            Assert.AreSame(list.Last, third);
            list.Clear();
            Assert.IsNull(list.Last);
        }

        /// <summary>
        /// Tests that the <see cref="LbSinglyLinkedList{T}"/> returns the correct type for the list.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void ReturnsCorrectType()
        {
            var list = new LbSinglyLinkedList<int>();
            Assert.AreEqual(list.Type, typeof(int));
            var list2 = new LbSinglyLinkedList<string>();
            Assert.AreEqual(list.Type, typeof(string));
        }

        /// <summary>
        /// Tests that the <see cref="LbSinglyLinkedList{T}"/> returns the correct node.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void AddNodeAfterCorrectly()
        {
            // TODO: Check all AddAfters are used
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var second = new LinkedListNode<int>();
            var third = new LinkedListNode<int>();
            var fourth = new LinkedListNode<int>();
            list.Append(first);
            list.Append(third);
            list.AddAfter(first, second);
            Assert.AreSame(list[1], second);
            list.AddAfter(third, fourth);
            Assert.AreSame(list[3], fourth);
        }

        
    }
}