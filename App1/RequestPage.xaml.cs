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
    /// 

    public sealed partial class RequestPage : Page
    {
        private CategoryModel cm;

        public RequestPage()
        {
            this.InitializeComponent();

            if(CategoryModel.SelectedCat != null)
            {
                cm = CategoryModel.SelectedCat;
                this.selectCat.Text = "Zmien kategorie";
                this.catName.Text = cm.Name;
            } else
            {
                this.catName.Text = "";
            }
        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {

            Frame.Navigate(typeof(Category));


        }
    }
}
