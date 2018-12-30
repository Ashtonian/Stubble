﻿// This file isn't generated, but this comment is necessary to exclude it from StyleCop analysis.
// <auto-generated />

using System;
using System.Collections;
using System.Net;
using System.Reflection;
using System.Text;

namespace Stubble.Compilation.Helpers
{
    /// <summary>
    /// A sealed class for static method infos that are only initalised once
    /// </summary>
    internal sealed class MethodInfos
    {
        /// <summary>
        /// A singleton of method infos to be used
        /// </summary>
        internal static MethodInfos Instance = new MethodInfos();

        internal readonly MethodInfo StringBuilderToString;
        internal readonly MethodInfo StringBuilderAppendString;
        internal readonly MethodInfo StringEqualWithComparison;
        internal readonly MethodInfo StringIsNullOrWhitespace;
        internal readonly MethodInfo GetEnumerator;
        internal readonly MethodInfo MoveNext;
        internal readonly MethodInfo HtmlEncode;
        internal readonly MethodInfo EnumeratorGetCurrent;
        internal readonly MethodInfo EnumeratorReset;

        public MethodInfos()
        {
            StringBuilderToString =
                typeof(StringBuilder).GetMethod(nameof(StringBuilder.ToString), Type.EmptyTypes);

            StringEqualWithComparison =
                typeof(string).GetMethod(nameof(string.Equals), new[] { typeof(string), typeof(StringComparison) });

            StringIsNullOrWhitespace =
                typeof(string).GetMethod(nameof(string.IsNullOrWhiteSpace), new[] { typeof(string) });

            GetEnumerator = typeof(IEnumerable).GetMethod(nameof(IEnumerable.GetEnumerator));

            MoveNext = typeof(IEnumerator).GetMethod(nameof(IEnumerator.MoveNext));

            StringBuilderAppendString =
                typeof(StringBuilder).GetMethod(nameof(StringBuilder.Append), new[] { typeof(string) });

            HtmlEncode = typeof(WebUtility).GetMethod(nameof(WebUtility.HtmlEncode), new[] { typeof(string) });

            EnumeratorGetCurrent = typeof(IEnumerator).GetProperty(nameof(IEnumerator.Current)).GetGetMethod();

            EnumeratorReset = typeof(IEnumerator).GetMethod(nameof(IEnumerator.Reset));
        }
    }
}
