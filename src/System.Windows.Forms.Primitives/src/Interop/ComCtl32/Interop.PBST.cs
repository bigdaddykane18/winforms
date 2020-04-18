﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

internal static partial class Interop
{
    internal static partial class ComCtl32
    {
        public enum PBST : int
        {
            NORMAL = 0x0001,
            ERROR = 0x0002,
            PAUSED = 0x0003,
        }
    }
}
