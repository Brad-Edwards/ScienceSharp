// <copyright file="ValueGenerator.cs" company="Brad Edwards">
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
using System.Linq;
using ScienceSharp.Exceptions;

namespace ScienceSharp.Utilities.Data
{
    /// <summary>
    /// Represents a random alpha-numeric value generator.
    /// </summary>
    public class ValueGenerator
    {
        /// <summary>
        /// The letters of the English alphabet in lowercase.
        /// </summary>
        private const string EnglishLetters = "abcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// The Arabic numerals.
        /// </summary>
        private const string ArabicNumerals = "1234567890";

        /// <summary>
        /// Random generator for <see cref="ValueGenerator"/>.
        /// </summary>
        private readonly Random _random;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueGenerator"/> class.
        /// </summary>
        public ValueGenerator()
        {
            _random = new Random();
            Language = Languages.English;
        }

        /// <summary>
        /// Uppercase and lowercase characters of the alphabet.
        /// </summary>
        public string AlphaChars => GenerateAlphaChars();

        /// <summary>
        /// Uppercase and lowercase characters of the alphabet and Arabic numerals.
        /// </summary>
        public string AlphaNumericChars => GenerateAlphaNumericChars();

        /// <summary>
        /// The current language of the <see cref="ValueGenerator"/> instance.
        /// </summary>
        /// <remarks>The default value is <see cref="Languages.English"/>.</remarks>
        public Languages Language { get; set; }

        /// <summary>
        /// Arabic numerals.
        /// </summary>
        public string NumericChars => GenerateNumericChars();

        /// <summary>
        /// Generates a <see cref="string"/> containing all of the lowercase and uppercase letters of the alphabet.
        /// </summary>
        /// <returns><see cref="string"/><para>All lowercase and uppercase letters of the alphabet without spaces.</para></returns>
        private string GenerateAlphaChars()
        {
            string str;
            switch (Language)
            {
                case Languages.English:
                    str = EnglishLetters;
                    str += str.ToUpper();
                    break;
                default:
                    throw new LanguageNotSetException("ValueGenerator " +
                        "instances must have a language set before " +
                        "generating alphabetic characters.");
            }
            return str;
        }

        /// <summary>
        /// Generates a <see cref="string"/> containing lowercase and uppercase letters, and digits.
        /// </summary>
        /// <returns><see cref="string"/><para>All lowercase and uppercase letters of the alphabet and digits without spaces.</para></returns>
        private string GenerateAlphaNumericChars()
        {
            // Language check is done in GenerateAlphaChars()
            return GenerateAlphaChars() + GenerateNumericChars();
        }

        /// <summary>
        /// Generates a <see cref="string"/> containing digits.
        /// </summary>
        /// <returns></returns>
        private string GenerateNumericChars()
        {
            return ArabicNumerals;
        }

        /// <summary>
        /// Creates a <see cref="string"/> of random alphabetic characters of the requested length.
        /// </summary>
        /// <param name="length">The length of the <see cref="string"/> to generate.</param>
        /// <returns><see cref="string"/><para>A <see cref="string"/> of random lower case and uppercase letters of the requested length.</para></returns>
        public string RandomAlpha(int length)
        {
            return new(Enumerable.Repeat(AlphaChars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Creates a <see cref="string"/> of random alphanumeric characters of the requested length.
        /// </summary>
        /// <param name="length">The length of the <see cref="string"/> to generate.</param>
        /// <returns><see cref="string"/><para>A <see cref="string"/> of random lowercase and uppercase letters and digits of the requested length.</para></returns>
        public string RandomAlphaNumeric(int length)
        {
            return new(Enumerable.Repeat(AlphaNumericChars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Creates a <see cref="string"/> of random numeric characters of the requested length.
        /// </summary>
        /// <param name="length">The length of the <see cref="string"/> to generate.</param>
        /// <returns><see cref="string"/><para>A <see cref="string"/> of random digits of the requested length.</para></returns>
        public string RandomNumeric(int length)
        {
            return new(Enumerable.Repeat(NumericChars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
