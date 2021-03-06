// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace System.Runtime.Loader.Tests
{
    public class TestClassNotSupported_ThreadStatic
    {
        [ThreadStatic]
        public static object ThisIsAThreadStatic;

        public struct S<T>
        {
            public T Value;
        }
    }

    public class TestClassNotSupported_FixedAddressValueType
    {
        public struct S<T>
        {
            public T Value;
        }

        [FixedAddressValueType]
        public static S<int> FixedInt;
    }
}
