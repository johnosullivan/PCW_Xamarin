using System;

using Xamarin.Forms;

namespace PCW
{
	public class App : Application
	{
		public static PCManager PCManager { get; private set; }
		public App()
		{

			PCManager = new PCManager(new RestService());
			MainPage = new RootPage();

			//MainPage = new NavigationPage(new Login());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
