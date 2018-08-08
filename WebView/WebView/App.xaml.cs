using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;


using Xamarin.Forms;

namespace WebView
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            MainPage = new NavigationPage(new WebView.MainPage());
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
		    AppCenter.Start("ios=7f70963d-aa05-4821-a747-06bf5118f4c5;" +
		                    "uwp={Your UWP App secret here};" +
		                    "android={Your Android App secret here}",
		        typeof(Analytics), typeof(Crashes));

		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
