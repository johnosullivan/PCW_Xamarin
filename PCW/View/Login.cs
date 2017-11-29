using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace PCW
{
	public class Login : GradientContentPage
	{
        EntryAuth usernameEntry, passwordEntry;
		Label messageLabel;
        ContentViewRoundedCorners c;
		public Login()
		{
			NavigationPage.SetHasNavigationBar(this, false);

            //BackgroundImage = "bgpattern.png";
            //BackgroundColor = Color.Black;
            BackgroundColor = Color.FromHex("3c8dbc");
			StartColor = Color.FromHex("3c8dbc");
			EndColor = Color.FromHex("15baa9");
			Title = "";
			messageLabel = new Label();
			messageLabel.Text = "PocketCoach";
			messageLabel.HorizontalTextAlignment = TextAlignment.Center;
            usernameEntry = new EntryAuth
			{
				Placeholder = "Username"
			};
            passwordEntry = new EntryAuth
			{
				IsPassword = true,
				Placeholder = "Password"
			};
			var loginButton = new Button
			{
				Text = "Sign In",
				BackgroundColor = Color.FromHex("15baa9"),
				TextColor = Color.White,
				HeightRequest = 45
			};
			var name = new Image { Aspect = Aspect.AspectFit };
			name.Source = ImageSource.FromFile("name.png");
			loginButton.Clicked += OnLoginButtonClicked;
			Padding = new Thickness(20, 20, 20, 20);
			c = new ContentViewRoundedCorners();
			c.Content = new StackLayout
			{
				Spacing = 20,
				Padding = new Thickness(20, 20, 20, 20),
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					new StackLayout {
						Padding = new Thickness(10, 10, 10, 10),
						VerticalOptions = LayoutOptions.Center,
						Children = {}
					},
					usernameEntry, passwordEntry, loginButton
				}
			};
			Content = new StackLayout
			{
				Padding = new Thickness(10, 10, 10, 10),
                Spacing = 20,
				VerticalOptions = LayoutOptions.Center,
                Children = { loginButton }
			};
		}
		async void OnLoginButtonClicked(object sender, EventArgs e)
		{
            //c.IsVisible = false;
			if (await App.PCManager.Login(usernameEntry.Text, passwordEntry.Text))
			{ await Navigation.PopModalAsync(); }
			else { await DisplayAlert("Accessed Denied!", "The following credentials are invalid. Please try again.", "Dismiss"); }
            
		}
	}
}

