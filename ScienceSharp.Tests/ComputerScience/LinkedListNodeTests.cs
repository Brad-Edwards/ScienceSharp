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

using NUnit.Framework;
using ScienceSharp.ComputerScience.DataStructures;
using ScienceSharp.Utilities.Data;

namespace ScienceSharp.Tests.ComputerScience
{
    /// <summary>
    /// Represents units tests for the <see cref="LinkedListNode{T}"/> class.
    /// </summary>
    [TestFixture]
    public class LinkedListNodeTests
    {
        /// <summary>
        /// The <see cref="LinkedListNode{T}"/> instance for testing.
        /// </summary>
        private LinkedListNode<string> _list;

        /// <summary>
        /// A value generator for node testing.
        /// </summary>
        private ValueGenerator _generator;

        /// <summary>
        /// Performs set up for unit testing the <see cref="LinkedListNode{T}"/> class.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _generator = new ValueGenerator();
            _list = new LinkedListNode<string>();
        }

        /// <summary>
        /// Tests that the node returns the correct next node value.
        /// </summary>
        [Test]
        public void NextNodeTest()
        {
            var nextNode = new LinkedListNode<string>();
            var node = new LinkedListNode<string> {
                Next = nextNode
            };
            Assert.AreEqual(node.Next, nextNode);
        }

        /// <summary>
        /// Tests that the node returns the previous next node value.
        /// </summary>
        [Test]
        public void PreviousNodeTest()
        {
            var previousNode = new LinkedListNode<string>();
            var node = new LinkedListNode<string> {
                Previous = previousNode
            };
            node.Previous = previousNode;
            Assert.AreEqual(node.Previous, previousNode);
        }

        /// <summary>
        /// Tests that the node returns the correct type for its underlying value.
        /// </summary>
        [Test]
        public void ReturnsRightType()
        {
            var node = new LinkedListNode<string>();
            Assert.AreEqual(node.ValueType, typeof(string));
            var node2 = new LinkedListNode<int>();
            Assert.AreEqual(node2.ValueType, typeof(int));
        }

        /// <summary>
        /// Tests that the node returns the correct value.
        /// </summary>
        [Test]
        public void ReturnsRightValue()
        {
            for (var i = 0; i < 10; i++)
            {
                var value = _generator.RandomAlphaNumeric(30);
                var node = new LinkedListNode<string> {
                    Value = value
                };
                Assert.AreEqual(node.Value, value);
                var node2 = new LinkedListNode<int>(i);
                Assert.AreEqual(node2.Value, i);
            }
        }
    }
}