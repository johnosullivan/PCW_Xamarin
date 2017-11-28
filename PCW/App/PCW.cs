using System;

using Xamarin.Forms;

namespace PCW
{
	public class App : Application
	{
		public static PCManager PCManager { get; private set; }
		public static bool mockRunning = true;
		public App()
		{
			PCManager = new PCManager(new RestService());
			MainPage = new RootPage();
		}
        protected override void OnStart() { }
		protected override void OnSleep() { }
		protected override void OnResume() { }
	}
}