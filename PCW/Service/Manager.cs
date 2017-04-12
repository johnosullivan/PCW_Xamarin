
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
		public Task<bool> Login (string username, string password) {
			return restService.Login (username, password);
		}

		public Task<bool> RefreshLogin(string username, string password)
		{
			return restService.RefreshLogin(username, password);
		}

        public string GetDisplayName()
        {
            return restService.GetDisplayName();
        }

        public string GetRole()
        {
            return restService.GetRole();
        }

		public string GetEmail()
		{
			return restService.GetEmail();
		}

        public string GetAccountID()
        {
            return restService.GetAccountID();
        }

        public string IsLoggined()
        {
            return restService.IsLoggined();
        }

		public string GetAccountProURL()
		{
			return restService.GetAccountProURL();
		}

	

    }
}