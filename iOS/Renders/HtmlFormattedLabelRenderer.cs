using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PCW;
using PCW.iOS;
using CoreGraphics;
using Foundation;
using UIKit;
using System.Drawing;
[assembly: ExportRenderer(typeof(HtmlFormattedLabel), typeof(HtmlFormattedLabelRenderer))]
namespace PCW.iOS
{
	
public class HtmlFormattedLabelRenderer : LabelRenderer
{
	protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
	{
		base.OnElementChanged(e);

		var view = (HtmlFormattedLabel)Element;
		if (view == null) return;

		var attr = new NSAttributedStringDocumentAttributes();
		var nsError = new NSError();
		attr.DocumentType = NSDocumentType.HTML;

		Control.AttributedText = new NSAttributedString(view.Text, attr, ref nsError);
   }
	}
}
