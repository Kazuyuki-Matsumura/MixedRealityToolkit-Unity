﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Internal.Interfaces.InputSystem;

namespace Microsoft.MixedReality.Toolkit.InputSystem.Sources
{
    public class GamepadInputSource : BaseGenericInputSource
    {
        public GamepadInputSource(string name, IMixedRealityPointer[] pointers = null) : base(name, pointers) { }
    }
}
