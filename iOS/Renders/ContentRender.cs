using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PCW;
using PCW.iOS;
using CoreGraphics;
using CoreAnimation;
using UIKit;
using System.Drawing;
[assembly: ExportRenderer(typeof(ContentViewRoundedCorners), typeof(ContentViewRoundedCornersRenderer))]

namespace PCW.iOS
{
class ContentViewRoundedCornersRenderer : VisualElementRenderer<ContentView>
{
	protected override void OnElementChanged(ElementChangedEventArgs<ContentView> e)
	{
		base.OnElementChanged(e);

		if (e.OldElement != null)
		{
			return;
		}
		Layer.MasksToBounds = false;
        Layer.CornerRadius = 10;
        Layer.ShadowColor = UIColor.DarkGray.CGColor;
        Layer.ShadowOpacity = 1.0f;
        Layer.ShadowRadius = 6.0f;
        Layer.ShadowOffset = new SizeF(0f, 3f);
		Layer.BackgroundColor = UIColor.White.CGColor;
		Layer.CornerRadius = ((ContentViewRoundedCorners)Element).CornerRadius;
	}
}
}
