﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information. 

using Microsoft.MixedReality.Toolkit.Internal.Definitions;
using UnityEditor;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Inspectors
{
    [CustomEditor(typeof(MixedRealityCameraProfile))]
    public class MixedRealityCameraProfileInspector : MixedRealityBaseConfigurationProfileInspector
    {
        private SerializedProperty opaqueNearClip;
        private SerializedProperty opaqueClearFlags;
        private SerializedProperty opaqueBackgroundColor;
        private SerializedProperty opaqueQualityLevel;

        private SerializedProperty transparentNearClip;
        private SerializedProperty transparentClearFlags;
        private SerializedProperty transparentBackgroundColor;
        private SerializedProperty holoLensQualityLevel;

        private GUIContent nearClipTitle;
        private GUIContent clearFlagsTitle;
        private GUIStyle headerStyle;

        private void OnEnable()
        {
            opaqueNearClip = serializedObject.FindProperty("nearClipPlaneOpaqueDisplay");
            opaqueClearFlags = serializedObject.FindProperty("cameraClearFlagsOpaqueDisplay");
            opaqueBackgroundColor = serializedObject.FindProperty("backgroundColorOpaqueDisplay");
            opaqueQualityLevel = serializedObject.FindProperty("opaqueQualityLevel");

            transparentNearClip = serializedObject.FindProperty("nearClipPlaneTransparentDisplay");
            transparentClearFlags = serializedObject.FindProperty("cameraClearFlagsTransparentDisplay");
            transparentBackgroundColor = serializedObject.FindProperty("backgroundColorTransparentDisplay");
            holoLensQualityLevel = serializedObject.FindProperty("holoLensQualityLevel");
        }

        public override void OnInspectorGUI()
        {
            nearClipTitle = new GUIContent("Near Clip");
            clearFlagsTitle = new GUIContent("Clear Flags");
            headerStyle = new GUIStyle("label") { richText = true };

            serializedObject.Update();

            EditorGUILayout.Space();
            EditorGUILayout.LabelField("<b>Opaque Display Settings:</b>", headerStyle);
            EditorGUILayout.PropertyField(opaqueNearClip, nearClipTitle);
            EditorGUILayout.PropertyField(opaqueClearFlags, clearFlagsTitle);

            if ((CameraClearFlags)opaqueClearFlags.intValue == CameraClearFlags.Color)
            {
                opaqueBackgroundColor.colorValue = EditorGUILayout.ColorField("Background Color", opaqueBackgroundColor.colorValue);
            }

            opaqueQualityLevel.intValue = EditorGUILayout.Popup("Quality Setting", opaqueQualityLevel.intValue, QualitySettings.names);

            EditorGUILayout.Space();
            EditorGUILayout.LabelField("<b>Transparent Display Settings:</b>", headerStyle);
            EditorGUILayout.PropertyField(transparentNearClip, nearClipTitle);
            EditorGUILayout.PropertyField(transparentClearFlags, clearFlagsTitle);

            if ((CameraClearFlags)transparentClearFlags.intValue == CameraClearFlags.Color)
            {
                transparentBackgroundColor.colorValue = EditorGUILayout.ColorField("Background Color", transparentBackgroundColor.colorValue);
            }

            holoLensQualityLevel.intValue = EditorGUILayout.Popup("Quality Setting", holoLensQualityLevel.intValue, QualitySettings.names);

            serializedObject.ApplyModifiedProperties();
        }
    }
}