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
    public sealed partial class DashboardSenior : Page
    {
        public DashboardSenior()
        {
            this.InitializeComponent();
            this.SplitView.IsPaneOpen = true;

            List<Menu> menuList = new List<Menu>();
            menuList.Add(new Menu() { Name = "Menu", Page = null });
            menuList.Add(new Menu() { Name = "Pomoc", Page = typeof(FastHelpPage) });
            menuList.Add(new Menu() { Name = "Zgloszenie", Page = typeof(RequestPage) });
            menuList.Add(new Menu() { Name = "Historia", Page = typeof(HistoryPage) });
            menuList.Add(new Menu() { Name = "Ustawienia", Page = typeof(SettingsPage) });
            Menu.ItemsSource = menuList;


        }



        private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Menu menu = Menu.SelectedItem as Menu;
            if(menu.Page != null)
            {
                this.FrameMain.Navigate(menu.Page);
                this.SplitView.IsPaneOpen = false;
            } else
            {
                this.SplitView.IsPaneOpen = !this.SplitView.IsPaneOpen;
            }
        
        }
    }
}
