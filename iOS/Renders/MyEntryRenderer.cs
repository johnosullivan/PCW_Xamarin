using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PCW;
using PCW.iOS;
using CoreGraphics;
using CoreAnimation;
using UIKit;
using System.Drawing;
using Foundation;

[assembly: ExportRenderer(typeof(EntryAuth), typeof(MyEntryRenderer))]
namespace PCW.iOS
{
	public class MyEntryRenderer : EntryRenderer
	{
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(119, 171, 233);
                Control.BorderStyle = UITextBorderStyle.None;
                Control.Font = UIFont.FromName("HelveticaNeue-Thin", 20);
                Control.SetValueForKeyPath(UIColor.White, new NSString("_placeholderLabel.textColor"));
                Control.Layer.SublayerTransform = CATransform3D.MakeTranslation(10, 0, 0);
            }
        }
	}
}
