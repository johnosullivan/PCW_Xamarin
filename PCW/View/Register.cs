using System;

using Xamarin.Forms;

namespace PCW
{
	public class Register : ContentPage
	{

		public Register()
		{
			Button button = new Button
			{
				Text = "Logoff",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			button.Clicked += OnButtonClicked;
			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					button
				}
			};
		}
		async void OnButtonClicked(object sender, EventArgs e)
		{
			bool status = await App.PCManager.LogoutAsync();
			if (status)
			{
				var page = new NavigationPage(new Login()) { Title = "Login Portal" };
				await Navigation.PushModalAsync(page);
			}
		}
	}
}
