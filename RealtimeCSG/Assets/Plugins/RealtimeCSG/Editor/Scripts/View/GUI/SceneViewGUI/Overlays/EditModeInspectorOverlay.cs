/* * * * * * * * * * * * * * * * * * * * * *
License:    MIT (https://tldrlegal.com/license/mit-license)
Author:     Daniel Cornelius
Date:       7/10/2021 @ 11:56 PM

* * * * * * * * * * * * * * * * * * * * * */

using UnityEditor;
using UnityEditor.Overlays;

namespace RealtimeCSG
{
    [Overlay( typeof( SceneView ), windowID, title )]
    public class EditModeInspectorOverlay : IMGUIOverlay
    {
        private const string title    = "RealtimeCSG";
        private const string windowID = "*RCSG_EDIT_MODE_INSPECTOR";

        public override void OnGUI()
        {
        }
    }
}
