using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using App1.Helpers;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Newtonsoft.Json;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RequestsPage : Page
    {
        public RequestsPage()
        {
            this.InitializeComponent();
            this.BindList();
            this.GetData();
        }
        private async void GetData()
        {
            var MapControl = MapHelper.GetMap();
            Grid.Children.Add(MapControl);
            HttpClient httpClient = new HttpClient();
            string response = await httpClient.GetStringAsync("http://localhost:2321/api/Orders");
            IEnumerable<OrderModel> orders = JsonConvert.DeserializeObject<IEnumerable<OrderModel>>(response);

            foreach (var model in orders)
            {

                var cityPosition = new BasicGeoposition()
                {
                    Latitude = model.Latitude,
                    Longitude = model.Longitude
                };
                Geopoint point = new Geopoint(cityPosition);
                var MapIcon1 = new MapIcon();
                MapIcon1.Location = point;
                MapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
                MapIcon1.Title = model.Name;

                MapControl.MapElements.Add(MapIcon1);
                MapControl.Center = point;
            }
        }

        private void BindList()
        {
            List<string> items = new List<string>();
            items.Add("xx");
            items.Add("yy");
            items.Add("xx");

            SelectItem.ItemsSource = items;
        }
    }
}
