using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Maps;

namespace App1.Helpers
{
    static class MapHelper
    {
        public static MapControl GetMap()
        {
            MapControl MapControl = new MapControl();
            MapControl.ZoomInteractionMode = MapInteractionMode.GestureAndControl;
            MapControl.TiltInteractionMode = MapInteractionMode.GestureAndControl;
            MapControl.MapServiceToken = "E3X8SkaGGw5ahsQ3uRu1~29zDEJ2YRCJX7TlnFv52wg~Aoa3aCWRhmixyhgyTvtrL8Rvf-E2vHYdQNBPKyJ62rkpXl55fnuVb08yL4BGomkI";

            MapControl.ZoomLevel = 15;
            MapControl.LandmarksVisible = true;
            MapControl.HorizontalAlignment = HorizontalAlignment.Stretch;
            MapControl.Height = 250;

            return MapControl;
        }
    }
}
