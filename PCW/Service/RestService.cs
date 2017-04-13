using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json.Linq;
//using PubNubMessaging.Core;
using Xamarin.Forms;
using Newtonsoft.Json;
/*
using System.Linq;
using Plugin.Settings;
using Plugin.Settings.Abstractions;*/

namespace PCW
{
	
	public class RestService : IRestService
	{
		HttpClient client;
		UserResponse uobject;
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
			var uri = new Uri("http://localhost:8080/api/auth/logout");
			var response = await client.GetAsync(uri);
			if (response.IsSuccessStatusCode) { return true; }
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
			var response = await client.PostAsync(uri, content);
			if (response.IsSuccessStatusCode)
			{
				var user = response.Content.ReadAsStringAsync().Result;
				uobject = JsonConvert.DeserializeObject<UserResponse>(user);
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", uobject.data.token);
				isLoggedIn = true;
				return true;
			}
			return false;
		}
	}
}
