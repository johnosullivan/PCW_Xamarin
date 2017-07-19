﻿using System;
using System.Collections.Generic;
using System.Linq;
using ImageCircle.Forms.Plugin.iOS;
using Foundation;
using UIKit;

namespace PCW.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			ImageCircleRenderer.Init();
			UIApplication.SharedApplication.SetStatusBarStyle (UIStatusBarStyle.Default, false);
			// Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif

			LoadApplication(new App());
			return base.FinishedLaunching(app, options);
		}
	}
}
