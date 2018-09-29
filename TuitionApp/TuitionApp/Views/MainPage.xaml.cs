using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuitionApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : MasterDetailPage
	{
        public MainPage()
        {
            InitializeComponent();
            this.Title = "Tuition App";
        }
    }
}