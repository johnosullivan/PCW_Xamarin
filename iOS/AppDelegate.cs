using System;
using System.Collections.Generic;
using System.Linq;
using ImageCircle.Forms.Plugin.iOS;
using Foundation;
using UIKit;
using Syncfusion.SfCalendar.XForms.iOS;

namespace PCW.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			ImageCircleRenderer.Init();

            new SfCalendarRenderer();

			UIApplication.SharedApplication.SetStatusBarStyle (UIStatusBarStyle.Default, false);

            #if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif

			LoadApplication(new App());
			return base.FinishedLaunching(app, options);
		}
	}
}
