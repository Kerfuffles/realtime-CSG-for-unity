/* * * * * * * * * * * * * * * * * * * * * *
License:    MIT (https://tldrlegal.com/license/mit-license)
Author:     Daniel Cornelius
Date:       7/10/2021 @ 10:10 PM

* * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.Reflection;
using RealtimeCSG.Foundation;
using UnityEditor;
using UnityEditor.Overlays;
using UnityEngine;

namespace RealtimeCSG
{
    [Overlay( typeof( SceneView ), windowID, title )]
    internal partial class EditModeToolbarOverlay : IMGUIOverlay
    {
        private const string title    = "RealtimeCSG";
        private const string windowID = "*RCSG_EDIT_MODE_TOOLBAR";

        public override void OnCreated()
        {
            base.OnCreated();

            this.displayName = $"{title} - V{Versioning.PluginVersion.Replace( '_', '.' )}";
            EditModeToolWindowSceneGUI.GetWindow().Close();
            EditModeToolbarShared.ToolbarOverlay = this;
        }

        public override void OnGUI()
        {
            InitStyles();

            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if( GUILayout.Button( GUIContent.none, "winbtnclose" ) )
            {
                EditModeToolWindowSceneGUI.GetWindow();
                this.displayed = false;
            }

            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal( GUILayout.Width( 490f ) );
            EditorGUI.BeginChangeCheck();
            ToolEditMode editMode = EditModeToolbar( EditModeManager.EditMode, toolbarContents );
            if( EditorGUI.EndChangeCheck() )
                EditModeManager.EditMode = editMode;

            GUILayout.EndHorizontal();
        }
    }
}
