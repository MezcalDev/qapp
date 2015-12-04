using System;

namespace qapp
{
	public interface IUser
	{
		string Name { get; set; }
		string Email { get; set; }
		string Description { get; set; }
	}
}

