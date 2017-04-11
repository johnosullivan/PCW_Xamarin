using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PCW;
using PCW.iOS;
using CoreGraphics;
using CoreAnimation;
using UIKit;
using System.Drawing;

[assembly: ExportRenderer(typeof(BorderView), typeof(BorderRender))]

namespace PCW.iOS
{
public class BorderRender : ViewRenderer<BorderView,UIView>
	{
		public BorderRender()
		{

		}
		UITextField username;
		UIView v;
		protected override void OnElementChanged(ElementChangedEventArgs<BorderView> e)
{
	base.OnElementChanged(e);

	if (Control == null)
	{
				// Instantiate the native control and assign it to the Control property with
				// the SetNativeControl method
				v = new UIView(new CGRect(0, 0, 10, 200));
				v.BackgroundColor = UIColor.White;
                v.Layer.MasksToBounds = false;
                v.Layer.CornerRadius = 10;
                v.Layer.ShadowColor = UIColor.DarkGray.CGColor;
                v.Layer.ShadowOpacity = 1.0f;
                v.Layer.ShadowRadius = 6.0f;
                v.Layer.ShadowOffset = new SizeF(0f, 3f);

				username = new UITextField(new CGRect(10, 30, 100, 30));
username.Placeholder = "Username";
				username.BorderStyle = UITextBorderStyle.RoundedRect;
				//v.Add(username);


UITextField password = new UITextField(new CGRect(10, 160, 300, 40));
password.Placeholder = "Password";
				password.SecureTextEntry = true;
				//v.Add(password);


				UIButton login = new UIButton(new CGRect(10, 150, 10, 40));
				login.SetTitle("Login",UIControlState.Normal);
				login.BackgroundColor = UIColor.Red;
				//v.Add(login);

                SetNativeControl(v);
	}

	if (e.OldElement != null)
	{
		// Unsubscribe from event handlers and cleanup any resources
	}

	if (e.NewElement != null)
	{
				//username.Frame = new CGRect(10, 10, 10, 30);	
		// Configure the control and subscribe to event handlers

 }
}


/*
		public override void Draw(CGRect rect)
		{
			base.Draw(rect);


			var context = UIGraphics.GetCurrentContext();

			context.SetLineWidth(4);
			UIColor.Red.SetFill();
			UIColor.Blue.SetStroke();

			var path = new CGPath();

			path.AddLines(new CGPoint[]{
				new PointF(100,200),
				new PointF(160,100),
				new PointF(220,200)
			});

			path.CloseSubpath();

			context.AddPath(path);
			context.DrawPath(CGPathDrawingMode.FillStroke);

		}*/
	}
}

