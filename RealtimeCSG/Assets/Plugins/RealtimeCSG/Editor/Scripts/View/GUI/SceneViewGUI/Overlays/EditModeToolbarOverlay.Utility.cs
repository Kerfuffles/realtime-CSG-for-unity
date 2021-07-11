/* * * * * * * * * * * * * * * * * * * * * *
License:    MIT (https://tldrlegal.com/license/mit-license)
Author:     Daniel Cornelius
Date:       7/10/2021 @ 10:38 PM

* * * * * * * * * * * * * * * * * * * * * */

using UnityEngine;

namespace RealtimeCSG
{
    internal partial class EditModeToolbarOverlay
    {
        private ToolEditMode EditModeToolbar( ToolEditMode editMode, GUIContent[] labels = null )
        {
            // place
            if( GUILayout.Toggle( editMode == ToolEditMode.Place, labels[0], toolbarButtonLeft, GUILayout.Width( toolbarButtonWidth ) ) )
            {
                editMode = ToolEditMode.Place;
            }

            // generate
            if( GUILayout.Toggle( editMode == ToolEditMode.Generate, labels[1], toolbarButtonMid, GUILayout.Width( toolbarButtonWidth ) ) )
            {
                editMode = ToolEditMode.Generate;
            }

            // edit
            if( GUILayout.Toggle( editMode == ToolEditMode.Edit, labels[2], toolbarButtonMid, GUILayout.Width( toolbarButtonWidth ) ) )
            {
                editMode = ToolEditMode.Edit;
            }

            // clip
            if( GUILayout.Toggle( editMode == ToolEditMode.Clip, labels[3], toolbarButtonMid, GUILayout.Width( toolbarButtonWidth ) ) )
            {
                editMode = ToolEditMode.Clip;
            }

            // surfaces
            if( GUILayout.Toggle( editMode == ToolEditMode.Surfaces, labels[4], toolbarButtonRight, GUILayout.Width( toolbarButtonWidth ) ) )
            {
                editMode = ToolEditMode.Surfaces;
            }

            return editMode;
        }
    }
}
