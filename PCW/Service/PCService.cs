using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace PCW
{
	public interface IRestService
	{
		/*Task<List<Team>> GetAllTeams ();

		Task<List<Athlete>> GetAllAthletes ();

        Task<List<Contact>> GetAllContacts();

        Task<List<Team>> GetAllMyTeams();

        Task<List<Event>> GetAllEvents();

        Task<List<Workout>> GetAllWorkouts();

		Task<List<User>> GetAllLAthletes();

		Task<List<User>> GetAllTeamAthletes(string teamid);

		Task<List<Request>> GetAllRequests();

		Task<TaskObject> GetAllTasks();

		Task<CheckinObject> GetAllCheckins();

		Task<List<MessageModel>> GetAllLMessages(string team);

		//Task<List<MessageModel>> GetAllLMessages(string team);

        Task SaveTodoItemAsync (bool item, bool isNewItem);

		Task<bool> DeleteTeamAsync(string id);

        Task<bool> LogoutAsync();

		Task<MessageModel> NewMessageAsync(string m, string team);
*/
        Task<bool> Login (string username, string password);

		Task<bool> RefreshLogin(string username, string password);

        string GetDisplayName();

        string GetRole();

		string GetEmail();

        string IsLoggined();

        string GetAccountID();

		string GetAccountProURL();

		//Dictionary<string,string> GetLastMessage(List<Team> teams);

		//Task<bool> AcceptRequest(Dictionary<string, string> data);

		//Task<bool> DenyRequest(Dictionary<string,string> data);
    }
}

