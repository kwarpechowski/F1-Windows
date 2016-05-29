using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using App1.Helpers;
using System;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    public sealed partial class Details : Page
    {
        private OrderModel Om { get; set; }

        public Details()
        {
            Om = OrderModel.SelectedOrder;
            this.InitializeComponent();
            this.SetData();
            this.SetMap();
        }

        private void SetMap()
        {
            var MapControl = MapHelper.GetMap();
            Grid.Children.Add(MapControl);

            var cityPosition = new BasicGeoposition()
            {
                Latitude = Om.Latitude,
                Longitude = Om.Longitude
            };
            Geopoint point = new Geopoint(cityPosition);
            MapControl.Center = point;

            var MapIcon1 = new MapIcon();
            MapIcon1.Location = point;
            MapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            MapIcon1.Title = OrderModel.SelectedOrder.SystemId;

            MapControl.MapElements.Add(MapIcon1);
        }

        private void SetData()
        {
           TitleHeader.Text = Om.SystemId;
           Status.Text = Om.Status.ToString();
        }
    }
}
