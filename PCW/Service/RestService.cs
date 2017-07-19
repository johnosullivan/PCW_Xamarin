using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace PCW
{
	public class RestService : IRestService
	{
		HttpClient client;
		UserResponse uobject;
		bool isLoggedIn = false;
		static string apiendpoint = "http://localhost:8080/api/";
		public RestService()
		{
			var cookies = new CookieContainer();
			var handler = new HttpClientHandler();
			handler.CookieContainer = cookies;
			client = new HttpClient(handler);
		}
		public bool LoggedIn() { return isLoggedIn; }
		public async Task<bool> LogoutAsync()
		{
			if (App.mockRunning) { return true; }
			var uri = new Uri(apiendpoint+ "auth/logout");
			var response = await client.GetAsync(uri);
			if (response.IsSuccessStatusCode) {
				isLoggedIn = false;
				return true; 
			}
			return false;
		}
		public async Task<bool> Login(string username, string password)
		{
			if (App.mockRunning) { return true; }
			var uri = new Uri(apiendpoint + "auth/login");
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
				if (uobject.error != null) {
					Logger.Log("Authorization Failed!");
					return false; 
				}
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", uobject.data.token);
				isLoggedIn = true;
				return true;
			}
			return false;
		}
	}
}
