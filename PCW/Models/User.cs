using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PCW
{
    public class User
    {
        public string _id { get; set; }
        public string token { get; set; }
    }
	public class Data
	{
		public User user { get; set; }
		public string token { get; set; }
	}

	public class UserResponse
	{
		public Data data { get; set; }
		public string message { get; set; }
	}

}