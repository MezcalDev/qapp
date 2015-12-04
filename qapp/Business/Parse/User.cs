using System;

namespace qapp
{
	public class User 
	{
		IUser _user;
		public User (IUser user)
		{
			_user = user;
		}
	}
}

