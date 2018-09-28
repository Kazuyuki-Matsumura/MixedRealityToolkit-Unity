﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.SDK.UX
{
    /// <summary>
    /// list of theme settings to virtualize theme values
    /// </summary>
    public struct ProfileSettings
    {
        public List<ThemeSettings> ThemeSettings;
    }

    /// <summary>
    /// List of settings that are copied from themes
    /// </summary>
    public struct ThemeSettings
    {
        public List<ThemePropertySettings> Settings;
    }

    /// <summary>
    /// The main settings found in Themes
    /// </summary>
    [System.Serializable]
    public struct ThemePropertySettings
    {
        public string Name;
        public Type Type;
        public ThemeBase Theme;
        public List<ThemeProperty> Properties;
        public List<ThemeProperty> History;
        public EaseSettings Easing;
        public bool NoEasing;
        public bool IsValid;
    }
}