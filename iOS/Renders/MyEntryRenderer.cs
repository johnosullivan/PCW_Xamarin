using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PCW;
using PCW.iOS;
using CoreGraphics;
using CoreAnimation;
using UIKit;
using System.Drawing;

[assembly: ExportRenderer(typeof(PCEntry), typeof(MyEntryRenderer))]
namespace PCW.iOS
{
	public class MyEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				// do whatever you want to the UITextField here!
				Control.BackgroundColor = UIColor.White;
				Control.BorderStyle = UITextBorderStyle.Line;

			}
		}
	}
}
