using System;

using Xamarin.Forms;

namespace PCW
{
	public class ContentViewRoundedCorners : ContentView
	{
		public ContentViewRoundedCorners()
		{
		}
		public static readonly BindableProperty CornerRaidusProperty =
		BindableProperty.Create<ContentViewRoundedCorners, float>(x => x.CornerRadius, 0);

		public float CornerRadius
		{
			get { return (float)GetValue(CornerRaidusProperty); }
			set { SetValue(CornerRaidusProperty, value); }
		}
	}
}

