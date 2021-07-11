/* * * * * * * * * * * * * * * * * * * * * *
License:    MIT (https://tldrlegal.com/license/mit-license)
Author:     Daniel Cornelius
Date:       7/11/2021 @ 12:50 AM

* * * * * * * * * * * * * * * * * * * * * */

using UnityEditor.Overlays;

namespace RealtimeCSG
{
    public static class EditModeToolbarShared
    {
        public static bool    ShowToolbar          { get; set; }
        public static Overlay ToolbarOverlay       { get; set; }
        public static Overlay InspectorOverlay     { get; set; }
        public static Overlay BottomToolbarOverlay { get; set; }
    }
}
