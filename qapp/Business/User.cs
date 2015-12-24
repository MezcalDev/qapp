using System;
using Parse;

namespace qapp
{
	public class User
	{
		class Constants {
			public const string Description = "description";
			public const string Name = "name";
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

		public async void SignUp ()
		{
			await _user.SignUpAsync();
		}
	}
}

