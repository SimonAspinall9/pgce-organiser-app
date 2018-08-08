using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebView
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    Browser.Source = "https://pgce-organiser.azurewebsites.net";
		    NavigationPage.SetHasNavigationBar(this, false);
		}
	}
}
