using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PCW;
using PCW.iOS;
using CoreGraphics;
using CoreAnimation;
using UIKit;

[assembly: ExportRenderer(typeof(Login), typeof(LoginRender))]

namespace PCW.iOS
{
	public class LoginRender : PageRenderer
	{
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);
			if (null != this.Element)
			{
				var page = e.NewElement as GradientContentPage;
				var gradientLayer = new CAGradientLayer();
				gradientLayer.Frame = View.Bounds;
				gradientLayer.StartPoint = new CGPoint(0, 0.5);
				gradientLayer.EndPoint = new CGPoint(1.0, 0.5);
				gradientLayer.Colors = new CGColor[] { page.StartColor.ToCGColor(), page.EndColor.ToCGColor() };
				var textureColor = UIColor.FromPatternImage(UIImage.FromFile("bg-pattern.png"));
				var back = new CALayer { Frame = View.Bounds };
				back.BackgroundColor = textureColor.CGColor;
				gradientLayer.AddSublayer(back);
				View.Layer.InsertSublayer(gradientLayer, 0);
			}
		}
	}
}
