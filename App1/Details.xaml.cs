using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using App1.Helpers;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Details : Page
    {
        public Details()
        {
            this.InitializeComponent();

   
            MapControl MapControl = MapHelper.GetMap();
            Grid.Children.Add(MapControl);

            BasicGeoposition cityPosition = new BasicGeoposition() {
                Latitude = OrderModel.SelectedOrder.Latitude,
                Longitude = OrderModel.SelectedOrder.Longitude
            };
            Geopoint point = new Geopoint(cityPosition);
            MapControl.Center = point;


            MapIcon MapIcon1 = new MapIcon();
            MapIcon1.Location = point;
            MapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            MapIcon1.Title = OrderModel.SelectedOrder.SystemId;
            MapControl.MapElements.Add(MapIcon1);
        }
    }
}
