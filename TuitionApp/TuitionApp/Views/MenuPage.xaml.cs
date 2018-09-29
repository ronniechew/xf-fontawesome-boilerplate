using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuitionApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuitionApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
            this.Title = "Tuition App";

            List<MainMenuModel> menuItemSource = new List<MainMenuModel>
            {
                new MainMenuModel { MenuName = "Main Page", Icon = "\uf0e7" },
                new MainMenuModel { MenuName = "History", Count = 287, Icon = "\uf21e" },
                new MainMenuModel { MenuName = "About", Icon = "\uf05a" }
            };

            mainMenuListView.ItemsSource = menuItemSource;
        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = e.Item as MainMenuModel;
            ((ListView)sender).SelectedItem = null;

            var masterDetail = ((MasterDetailPage)App.Current.MainPage);

            switch (selectedItem.MenuName)
            {
                case "About":
                    masterDetail.Detail = new NavigationPage(new AboutPage());
                    masterDetail.IsPresented = false;
                    break;
            }
        }
    }
}