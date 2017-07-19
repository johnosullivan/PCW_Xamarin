using System;

using Xamarin.Forms;

namespace PCW
{
	public class Dashboard : ContentPage
	{
		public Dashboard()
		{
			Title = "Dashboard";
			Button button = new Button
			{
				Text = "Logoff",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				TextColor = Color.Black
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

