/* * * * * * * * * * * * * * * * * * * * * *
License:    MIT (https://tldrlegal.com/license/mit-license)
Author:     Daniel Cornelius
Date:       7/10/2021 @ 10:31 PM

* * * * * * * * * * * * * * * * * * * * * */

using UnityEngine;

namespace RealtimeCSG
{
    internal partial class EditModeToolbarOverlay
    {
        private const string toolbarLeftButtonStyle  = "buttonleft";
        private const string toolbarMidButtonStyle   = "buttonmid";
        private const string toolbarRightButtonStyle = "buttonright";

        private static GUIStyle toolbarButtonLeft;
        private static GUIStyle toolbarButtonMid;
        private static GUIStyle toolbarButtonRight;

        private const float toolbarButtonWidth = 98f;

        private static GUIContent[] toolbarContents;

        private static void InitStyles()
        {
            toolbarButtonLeft  ??= new GUIStyle( toolbarLeftButtonStyle );
            toolbarButtonMid   ??= new GUIStyle( toolbarMidButtonStyle );
            toolbarButtonRight ??= new GUIStyle( toolbarRightButtonStyle );

            toolbarContents ??= new[]
            {
                new GUIContent( "Place",    $"PLACE\n\nIn this mode you can place, rotate and scale brushes.\n\nShortcut: {Keys.SwitchToObjectEditMode}" ),
                new GUIContent( "Generate", $"GENERATE\n\nIn this mode you can create brushes using several generators\n\nShortcut: {Keys.SwitchToGenerateEditMode}" ),
                new GUIContent( "Edit",     $"EDIT\n\nIn this mode you can create brushes using several generators.\n\nShortcut: {Keys.SwitchToMeshEditMode}" ),
                new GUIContent( "Clip",     $"CLIP\n\nIn this mode you can split or clip brushes.\n\nShortcut: {Keys.SwitchToClipEditMode}" ),
                new GUIContent( "Surfaces", $"SURFACES\n\nIn this mode you can modify the texturing and everything else related to brush surfaces.\n\nShortcut: {Keys.SwitchToSurfaceEditMode}" )
            };
        }
    }
}
