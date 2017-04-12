using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json.Linq;
//using PubNubMessaging.Core;
using Xamarin.Forms;
/*
using System.Linq;
using Plugin.Settings;
using Plugin.Settings.Abstractions;*/

namespace PCW
{
	
	public class RestService : IRestService
	{
		HttpClient client;

		JObject userdata;

		bool isLoggedIn = false;


		public RestService()
		{

			var cookies = new CookieContainer();

			var handler = new HttpClientHandler();

			handler.CookieContainer = cookies;

			client = new HttpClient(handler);

		}



		public async Task<bool> LogoutAsync()
		{
			var uri = new Uri("http://www.pocketcoachweb.com/api/auth/signout");

			var response = await client.GetAsync(uri);

			if (response.IsSuccessStatusCode)
			{
				

			}
			return false;
		}

		public async Task<bool> DeleteTeamAsync(string id)
		{
			var uri = new Uri("http://www.pocketcoachweb.com/api/teams/" + id);

			var response = await client.DeleteAsync(uri);

			if (response.IsSuccessStatusCode)
			{
				return true;
			}
			return false;
		}

		public async Task<bool> RefreshLogin(string username, string password)
		{
			var uri = new Uri("http://www.pocketcoachweb.com/api/auth/signin");
			var values = new Dictionary<string, string>();
			values.Add("username", username);
			values.Add("password", password);
			values.Add("charset", Encoding.UTF8.ToString());
			values.Add("Content-Type", "application/x-www-form-urlencoded");
			var content = new FormUrlEncodedContent(values);
			var response = await client.PostAsync(uri, content);
			if (response.IsSuccessStatusCode)
			{
				
				return true;
			}
			return false;
		}

		public async Task<bool> Login(string username, string password)
		{

			var uri = new Uri("http://localhost:8080/api/auth/login");

			var values = new Dictionary<string, string>();

			values.Add("username", username);
			values.Add("password", password);
			values.Add("charset", Encoding.UTF8.ToString());
			values.Add("Content-Type", "application/json");

			var content = new FormUrlEncodedContent(values);
			Debug.WriteLine(content);
			var response = await client.PostAsync(uri, content);

			if (response.IsSuccessStatusCode)
			{

				return true;
			}
			return false;
		}





		public string GetDisplayName()
		{
			var name = userdata["displayName"];
			return (string)name;
		}
		public string GetAccountProURL()
		{
			var name = userdata["profileImageURL"];
			return (string)name;
		}
		public string GetAccountID()
		{
			var id = userdata["_id"];
			return (string)id;
		}
		public string GetEmail()
		{
			var id = userdata["email"];
			return (string)id;
		}

		public string IsLoggined()
		{
			if (isLoggedIn)
			{
				return "y";
			}
			else
			{
				return "n";
			}
		}

		public string GetRole()
		{

			if (isLoggedIn)
			{

				JArray array = (JArray)userdata["roles"];

				List<string> list = userdata["roles"].ToObject<List<string>>();

				if (list.Contains("athlete"))
				{
					return "athlete";
				}

				return "user";

			}

			return "user";
		}




	

	}
}
