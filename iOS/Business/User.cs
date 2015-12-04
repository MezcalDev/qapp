using System;
using Parse;

namespace qapp.iOS
{
	public class User : IUser
	{
		class Constants {
			public static string Description = "description";
			public static string Name = "name";
		}

		ParseUser _user;

		public string Email 
		{ 
			get { return _user.Email; } 
			set { _user.Email = value; } 
		}

		public string Name 
		{ 
			get { return (string) _user [Constants.Name]; } 
			set { _user [Constants.Name] = value; }
		}

		public string Description 
		{ 
			get { return (string) _user [Constants.Description]; } 
			set { _user [Constants.Description] = value; }
		}

		public User (ParseUser user)
		{
			_user = user;
		}
	}
}

