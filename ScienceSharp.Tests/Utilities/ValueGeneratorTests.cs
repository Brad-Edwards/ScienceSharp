// <copyright file="ValueGeneratorTests.cs" company="Brad Edwards">
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
using ScienceSharp.Utilities.Data;
using System;
using System.Linq;

namespace ScienceSharp.Tests.Utilities
{
    /// <summary>
    /// Represents unit tests for the <see cref="ValueGenerator"/> class.
    /// </summary>
    [TestFixture]
    [TestOf(typeof(ValueGenerator))]
    public class ValueGeneratorTests
    {
        /// <summary>
        /// A <see cref="ValueGenerator"/> instance for testing.
        /// </summary>
        private ValueGenerator _valueGenerator;

        /// <summary>
        /// Completes any setup needed for tests.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _valueGenerator = new ValueGenerator();
        }

        /// <summary>
        /// Checks the reference values for alpha-numeric values are correct contain only digits and letters.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void ContainsOnlyLettersAndNumbers()
        {
            Assert.True(_valueGenerator.AlphaNumericChars.All(Char.IsLetterOrDigit));
        }

        /// <summary>
        /// Checks the reference values for alphabetic values are correct contain only letters.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void ContainsOnlyLetters()
        {
            Assert.True(_valueGenerator.AlphaChars.All(char.IsLetter));
        }

        /// <summary>
        /// Checks the reference values for numerical values contain only digits.
        /// </summary>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void ContainsOnlyDigits()
        {
            Assert.True(_valueGenerator.NumericChars.All(char.IsDigit));
        }

        /// <summary>
        /// Checks that the right number of random letters is generated.
        /// </summary>
        /// <remarks>Tests values are up to 30 characaters long.</remarks>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void CreatesCorrectNumberOfRandomLetters()
        {
            var rnd = new Random();
            for (var i = 0; i < 10; i++)
            {
                var x = (int) Math.Floor(rnd.Next(1,30) * 1.0);
                var values = _valueGenerator.RandomAlpha(x);
                Assert.True(values.Count() == x);
                Assert.True(values.All(char.IsLetter));
            }
        }

        /// <summary>
        /// Checks that the right number of random letters and numbers is generated.
        /// </summary>
        /// <remarks>Tests values are up to 30 characaters long.</remarks>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void CreatesCorrectNumberOfRandomLettersNumbers()
        {
            var rnd = new Random();
            for (var i = 0; i < 10; i++)
            {
                var x = (int) Math.Floor(rnd.Next(1,30) * 1.0);
                var values = _valueGenerator.RandomAlphaNumeric(x);
                Assert.True(values.Count() == x);
                Assert.True(values.All(char.IsLetterOrDigit));
            }
        }

        /// <summary>
        /// Checks that the right number of numbers is generated.
        /// </summary>
        /// <remarks>Tests values are up to 30 characaters long.</remarks>
        [Test]
        [Author("Brad Edwards", "j.bradley.edwards@gmail.com")]
        public void CreatesCorrectNumberOfRandomNumbers()
        {
            var rnd = new Random();
            for (var i = 0; i < 10; i++)
            {
                var x = (int) Math.Floor(rnd.Next(1,30) * 1.0);
                var values = _valueGenerator.RandomNumeric(x);
                Assert.True(values.Count() == x);
                Assert.True(values.All(char.IsDigit));
            }
        }
    }
}