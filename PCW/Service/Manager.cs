
using System.Collections.Generic;
using System.Threading.Tasks;


namespace PCW
{
	public class PCManager
	{
		IRestService restService;

		public PCManager(IRestService service)
		{
			restService = service;
		}
		public Task<bool> Login(string username, string password)
		{
			return restService.Login(username, password);
		}

		public Task<bool> LogoutAsync()
		{
			return restService.LogoutAsync();
		}






	}
}