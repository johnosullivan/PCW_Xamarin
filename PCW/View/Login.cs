﻿using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace PCW
{
	public class Login : GradientContentPage
	{
		Entry usernameEntry, passwordEntry;
		Label messageLabel;
		public Login()
		{
			NavigationPage.SetHasNavigationBar(this, false);
			StartColor = Color.FromHex("3c8dbc");
			EndColor = Color.FromHex("15baa9");

			Title = "";
			messageLabel = new Label();
			messageLabel.Text = "PocketCoach";
			messageLabel.HorizontalTextAlignment = TextAlignment.Center;

			usernameEntry = new Entry
			{
				Placeholder = "Username"
			};
			passwordEntry = new Entry
			{
				IsPassword = true,
				Placeholder = "Password"
			};
			var loginButton = new Button
			{
				Text = "Sign In",
				BackgroundColor = Color.FromHex("15baa9"),
				TextColor = Color.White,
				HeightRequest = 35
			};
			var name = new Image { Aspect = Aspect.AspectFit };
			name.Source = ImageSource.FromFile("name.png");
			loginButton.Clicked += OnLoginButtonClicked;
			//BorderView b = new BorderView();
			Padding = new Thickness(20, 20, 20, 20);
			ContentViewRoundedCorners c = new ContentViewRoundedCorners();
			c.CornerRadius = 10;
			c.Content = new StackLayout
			{
				Spacing = 15,
				Padding = new Thickness(20, 20, 20, 20),
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					new StackLayout {
						Padding = new Thickness(30, 10, 30, 10),
						VerticalOptions = LayoutOptions.Center,
						Children = {name}
					},
					usernameEntry,
					passwordEntry,
					loginButton
				}
			};
			Content = new StackLayout
			{
				Padding = new Thickness(10, 10, 10, 10),
				VerticalOptions = LayoutOptions.Center,
				Children = {
					c
				}

			};
		}
		async void OnLoginButtonClicked(object sender, EventArgs e)
		{
			Debug.WriteLine("Login");
			await Navigation.PopModalAsync();
		}
	}
}

