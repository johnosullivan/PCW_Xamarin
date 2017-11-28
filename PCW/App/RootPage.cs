using System;
using Xamarin.Forms;
using System.Linq;

namespace PCW
{
	public class RootPage : MasterDetailPage
	{
		MenuPage menuPage;

		public RootPage ()
		{
            menuPage = new MenuPage ();
			menuPage.Menu.ItemSelected += (sender, e) => NavigateTo (e.SelectedItem as MenuItem);
            menuPage.SetValue(NavigationPage.BarTextColorProperty, Color.Maroon);

            Master = menuPage;
			Detail = new NavigationPage(new Dashboard()) { BarBackgroundColor = Color.FromHex("12a798"), BarTextColor = Color.White };

			ShowLoginDialog();
        }

		async void ShowLoginDialog()
		{
			var page = new NavigationPage(new Login()) { BarBackgroundColor = Color.FromHex("12a798"), BarTextColor = Color.White, Title = "Login Portal" };
			await Navigation.PushModalAsync(page, false);
		}

		void NavigateTo (MenuItem menu)
		{
			if (menu == null) return; 
			Page displayPage = (Page)Activator.CreateInstance (menu.TargetType);
			Detail = new NavigationPage(displayPage) { BarBackgroundColor = Color.FromHex("12a798"), BarTextColor = Color.White };
			menuPage.Menu.SelectedItem = null;
			IsPresented = false;
		}

		protected override void OnAppearing(){
            base.OnAppearing();
		}
	}
}