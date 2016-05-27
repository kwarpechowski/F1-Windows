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
    public sealed partial class Category : Page
    {
        public Category()
        {
            this.InitializeComponent();
            new CategoryModel() { Name = "Kat1" };
            new CategoryModel() { Name = "Kat2" };
            CategoryModel c3 = new CategoryModel() { Name = "Kat3" };
            c3.Children.Add(new CategoryModel() { Name = "Kat 3.1" });
            c3.Children.Add(new CategoryModel() { Name = "Kat 3.2" });
            c3.Children.Add(new CategoryModel() { Name = "Kat 3.3" });

            CatList.ItemsSource = CategoryModel.Categories;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RequestPage));
        }
  

        private void CatList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                CategoryModel cm = CatList.SelectedItem as CategoryModel;
                if (cm.Children.Count > 0)
                {
                    CatList.ItemsSource = null;
                    CatList.ItemsSource = cm.Children;
                }
                else
                {
                    CategoryModel.SelectedCat = cm;
                    Frame.Navigate(typeof(RequestPage));
                }
            } catch(Exception)
            {

            }
        }
    }
}
