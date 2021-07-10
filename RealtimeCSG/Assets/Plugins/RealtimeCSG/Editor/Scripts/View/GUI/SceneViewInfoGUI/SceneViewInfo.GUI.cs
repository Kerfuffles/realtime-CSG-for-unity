/* * * * * * * * * * * * * * * * * * * * * *
RealtimeCSG.SceneViewInfo.GUI.cs

License:
Author: Daniel Cornelius

Description:
Handles drawing information in the scene view, such as brush and model count.
* * * * * * * * * * * * * * * * * * * * * */

using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEditor.Overlays;

namespace RealtimeCSG
{
    [Overlay( typeof( SceneView ), olid, "RCSG Scene Info" )]
    internal sealed partial class SceneViewInfoGUI : IMGUIOverlay
    {
        private const  string        olid = "RCSG_IMGUI_SV_INFO_OVERLAY";
        private static StringBuilder sb   = new StringBuilder( 64 );

        private static void DrawInfoGUI()
        {
            InitStyles();
            CSG_GUIStyleUtility.InitStyles();

            try
            {
                Handles.BeginGUI();

                if( !CSGSettings.ShowSceneInfo )
                    return;

                // -Nuke: internally there is a root model that all other models are grouped under, so we'll subtract 1 to keep an accurate count of user created brushes.
                int modelCount = Mathf.Clamp( InternalCSGModelManager.Models.Length - 1, 0, int.MaxValue );
                int brushCount = InternalCSGModelManager.Brushes.Count;

                sb = new StringBuilder( 64 );
                sb.Append( "Models:\t" )
                  .Append( modelCount )
                  .Append( "\nBrushes:\t" )
                  .Append( brushCount );

                GUILayout.Label
                (
                        sb.ToString(),
                        infoGUIStyle,
                        GUILayout.Height( infoGUILabelHeight )
                );
            }
            finally
            {
                Handles.EndGUI();
            }
        }

        /// <inheritdoc />
        public override void OnGUI()
        {
            DrawInfoGUI();
        }
    }
}
