using System;

using Xamarin.Forms;

namespace PCW
{
	public class App : Application
	{
        // PCManager global access
		public static PCManager PCManager { 
            get; private set; 
        }
        // mockRunning trigger to toggle between live and mock
		public static bool mockRunning = true;
        // Application entry point
		public App()
		{
            // A new initialize of the Rest manager using the RestService interface 
			PCManager = new PCManager(new RestService());
            // UI sets the main page to the RootPage ContectView
			MainPage = new RootPage();
		}
        // Lifecycle of the application, triggers when the application is opened 
        protected override void OnStart() { 
        
        }
        // Lifecycle of the application, triggers when the application is closed
		protected override void OnSleep() { 
        
        }
        // Lifecycle of the application, triggers when the application is reopened from multitasking
		protected override void OnResume() { 
        
        }
	}
}