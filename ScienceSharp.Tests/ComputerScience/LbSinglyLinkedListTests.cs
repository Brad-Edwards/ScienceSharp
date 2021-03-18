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

using System.Runtime.CompilerServices;
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
        /// Tests that <see cref="LbSinglyLinkedList{T}.Count"/> returns the right number of <see cref="ILinkedListNode{T}"/> instances in the list.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void Count_Any_ReturnsCorrectNodeCount()
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
        /// Tests that <see cref="LbSinglyLinkedList{T}.First"/> accurately returns the first node in the list.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void First_Any_ReturnsCorrectFirstNode()
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
        /// Tests that the <see cref="LbSinglyLinkedList{T}.IsEmpty"/> accurately reports when it is empty.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void IsEmpty_Any_ReturnsListEmptyStatusCorrectly()
        {
            var list = new LbSinglyLinkedList<int>();
            Assert.True(list.IsEmpty);
            list.Append(new LinkedListNode<int>());
            Assert.False(list.IsEmpty);
            list.Clear();
            Assert.True(list.IsEmpty);
        }

        /// <summary>
        /// Tests that the <see cref="LbSinglyLinkedList{T}.Last"/> correctly returns the last node in the list.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void Last_Any_ReturnsLastNodeCorrectly()
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
        /// Tests that the <see cref="LbSinglyLinkedList{T}.Type"/> returns the correct type for the list.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void Type_Any_ReturnsCorrectType()
        {
            var list = new LbSinglyLinkedList<int>();
            Assert.AreEqual(list.Type, typeof(int));
            var list2 = new LbSinglyLinkedList<string>();
            Assert.AreEqual(list.Type, typeof(string));
        }

        /// <summary>
        /// Tests that the <see cref="LbSinglyLinkedList{T}.AddAfter(ILinkedListNode&lt;T&gt;, T)"/> returns the correct value.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void AddAfter_AddValue_AddsValueAfterNode()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var value = 42;
            var third = new LinkedListNode<int>();
            var fourth = new LinkedListNode<int>();
            list.Append(first);
            list.AddAfter(first, value);
            Assert.AreEqual(list[1], value);
            list.Append(third);
            list.AddAfter(third, value);
            Assert.AreEqual(list[3], value);

            var list2 = new LbSinglyLinkedList<object>();
            var first2 = new LinkedListNode<object>();
            var value2 = new object();
            var third2 = new LinkedListNode<object>();
            var fourth2 = new LinkedListNode<object>();
            list2.Append(first2);
            list2.AddAfter(first2, value2);
            Assert.AreSame(list2[1], value2);
            list2.Append(third2);
            list2.AddAfter(third2, value2);
            Assert.AreSame(list[3], value2);
        }

        /// <summary>
        /// Test that the <see cref="LbSinglyLinkedList{T}.AddAfter(ILinkedListNode&lt;T&gt;, ILinkedListNode&lt;T&gt;"/> returns the correct node.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void AddAfter_AddNode_AddsNodeAfterNode()
        {
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

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.AddBefore(ILinkedListNode&lt;T&gt;, T)"/> sets value in the correct position.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void AddBefore_AddValue_AddsValueBeforeNode()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var value = 42;
            var third = new LinkedListNode<int>();
            var fourth = new LinkedListNode<int>();
            list.Append(first);
            list.AddBefore(first, value);
            Assert.AreEqual(list[0], value);
            list.Append(third);
            list.Append(fourth);
            list.AddBefore(fourth, value);
            Assert.AreEqual(list[3], value);

            var list2 = new LbSinglyLinkedList<object>();
            var first2 = new LinkedListNode<object>();
            var value2 = new object();
            var third2 = new LinkedListNode<object>();
            var fourth2 = new LinkedListNode<object>();
            list.Append(first);
            list.AddBefore(first, value);
            Assert.AreSame(list[0], value);
            list.Append(third);
            list.Append(fourth);
            list.AddBefore(fourth, value);
            Assert.AreSame(list[3], value);
        }

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.AddBefore(ILinkedListNode&lt;T&gt;, ILinkedListNode&lt;T&gt;)"/> sets node in correct position.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void AddBefore_AddNode_AddsNodeBeforeNode()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var second = new LinkedListNode<int>();
            var third = new LinkedListNode<int>();
            var fourth = new LinkedListNode<int>();
            var value = 42;
            list.Append(first);
            list.AddBefore(first, value);
            Assert.AreSame(list[0], value);
            list.Append(second);
            list.Append(third);
            list.Append(fourth);
            list.AddBefore(third, value);
            Assert.AreSame(list[2], value);
        }

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.AddFirst(T)"/> sets first node correctly.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void AddFirst_AddValue_AddsValueToStartOfList()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var value = 42;
            list.Append(first);
            list.AddFirst(value);
            Assert.AreEqual(list[0], value);

            var list2 = new LbSinglyLinkedList<object>();
            var first2 = new LinkedListNode<object>();
            var value2 = new object();
            list2.Append(first2);
            list2.AddFirst(value2);
            Assert.AreSame(list[0], value2);
        }

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.AddFirst(ILinkedListNode&lt;T&gt;)"/> sets first node correctly.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void AddFirst_AddNode_AddsNodeToStartOfList()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var value = new LinkedListNode<int>();
            list.Append(first);
            list.AddFirst(value);
            Assert.AreSame(list[0], value);
        }

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.Append(T)"/> adds value to end of list.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void Append_AddValue_AddsValueToEndOfList()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var value = 42;
            list.Append(first);
            list.Append(value);
            Assert.AreEqual(list[-1], value);

            var list2 = new LbSinglyLinkedList<object>();
            var first2 = new LinkedListNode<object>();
            var value2 = new object();
            list2.Append(first2);
            list2.Append(value2);
            Assert.AreSame(list2[-1], value2);
        }

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.Append(ILinkedListNode&lt;T&gt;)"/> adds node to end of list.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void Append_AddNode_AddsNodeToEndOfList()
        {
            var list = new LbSinglyLinkedList<int>();
            var value = new LinkedListNode<int>();
            var first = new LinkedListNode<int>();
            list.Append(first);
            list.Append(value);
            Assert.AreSame(list[-1], value);
        }

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.Clear"/> empties the list.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void Clear_FiveNodeList_ListIsEmpty()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var second = new LinkedListNode<int>();
            list.Append(first);
            list.Append(second);
            Assert.True(list.Count > 0);
            list.Clear();
            Assert.True(list.Count == 0);
        }

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.Contains"/> returns <value>true</value> only when the list actually contains a given value.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void Contains_Value_ReturnsTrueOnlyWhenContainsValue()
        {
            var list = new LbSinglyLinkedList<int>();
            var value1 = 42;
            var value2 = 12;
            list.Append(value1);
            list.Append(value2);
            Assert.True(list.Contains(value1));
            Assert.True(list.Contains(value2));
            list.Remove(value1);
            Assert.False(list.Contains(value1));
        }

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.Find"/> returns <see cref="ILinkedListNode{T}"/> with correct value only when value is in list, otherwise it returns null.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void Find_Value_ReturnsNodeWithValueOnlyWhenListContainsValue()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var value = 42;
            list.Append(first);
            Assert.Null(list.Find(value));
            list.Append(value);
            Assert.AreEqual(list.Find(value).Value, value);
            list.Append(value);
            Assert.AreSame(list.Find(value), list[1]);
        }

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.FindLast"/> returns <see cref="ILinkedListNode{T}"/> with correct value only when value is in the list, otherwise it returns null.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void FindLast_Value_ReturnsNodeWithValueOnlyWhenListContainsValue()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var value = 42;
            Assert.Null(list.Find(value));
            list.Append(value);
            list.Append(first);
            list.Append(value);
            Assert.AreSame(list.FindLast(value), list[2]);
        }

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.Remove(T)"/> returns true only if the first node containing a value was removed.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void Remove_Value_ReturnsListWithValueRemoved()
        {
            var list = new LbSinglyLinkedList<int>();
            var value = 7;
            var first = new LinkedListNode<int>(value);
            var second = new LinkedListNode<int>(40);
            var third = new LinkedListNode<int>(value);
            list.Append(first);
            Assert.True(list.Remove(value));
            Assert.True(list.Count == 0);
            Assert.False(list.Remove(value));
            list.Append(first);
            list.Append(second);
            list.Append(third);
            list.Remove(first);
            for (var i = 0; i < list.Count; i++)
            {
                Assert.AreNotSame(list[i], first);
            }
        }

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.Remove(ILinkedListNode&lt;T&gt;)"/> returns true only if the first incidence of a node is removed.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void Remove_Node_ReturnsListWithNodeRemoved()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var second = new LinkedListNode<int>();
            list.Append(first);
            Assert.True(list.Remove(first));
            Assert.False(list.Remove(first));
            list.Append(first);
            list.Append(second);
            list.Append(first);
            list.Remove(first);
            Assert.AreNotSame(list[0], first);
            Assert.AreSame(list[1], first);
        }

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.RemoveFirst"/> removes the first node from the list.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void RemoveFirst_Any_RemovesFirstNode()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var second = new LinkedListNode<int>();
            var third = new LinkedListNode<int>();
            list.Append(first);
            list.RemoveFirst();
            list.Append(first);
            list.Append(second);
            list.Append(third);
            list.RemoveFirst();
            for (var i = 0; i < list.Count; i++)
            {
                Assert.AreNotSame(list[i], first);
            }
        }

        /// <summary>
        /// <see cref="LbSinglyLinkedList{T}.RemoveLast"/> removes the last node from the list.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void RemoveLast_Any_RemovesLastNode()
        {
            var list = new LbSinglyLinkedList<int>();
            var first = new LinkedListNode<int>();
            var second = new LinkedListNode<int>();
            var third = new LinkedListNode<int>();
            list.Append(first);
            list.Append(second);
            list.Append(third);
            list.RemoveLast();
            for (var i = 0; i < list.Count; i++)
            {
                Assert.AreNotSame(list[i], third);
            }
        }
    }
}