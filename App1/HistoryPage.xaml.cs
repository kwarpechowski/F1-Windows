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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HistoryPage : Page
    {
        public HistoryPage()
        {
            this.InitializeComponent();
            new OrderModel() { SystemId = "1x" };
            new OrderModel() { SystemId = "2v" };
            new OrderModel() { SystemId = "3d" };
            new OrderModel() { SystemId = "4f" };

            var orders = OrderModel.GetOrders();

            HistoryList.ItemsSource = orders;
            this.textBox.Text = "Historia (" + orders.Count().ToString() + ")";
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {

            OrderModel.SelectedOrder = (OrderModel)((FrameworkElement)sender).DataContext;
            Frame.Navigate(typeof(Details));
        }
    }
}
