using System;
using Parse;

namespace qapp
{
	public class ParseManager
	{
		public ParseManager ()
		{
			Parse.ParseClient.Initialize (Constants.AppId, Constants.NetID);
		}

		static public readonly ParseManager SharedInstance = new ParseManager ();

		//Test
		async public void TestParse()
		{
			var testObject = new ParseObject ("TestObject");
			testObject ["foo"] = "bars";
			await testObject.SaveAsync ();
		}
			

		async public void TestParseSignUp()
		{
			var user = new ParseUser()
			{
				Username = "my name",
				Password = "my pass",
				Email = "email@example.com"
			};

			// other fields can be set just like with ParseObject
			user["phone"] = "650-555-0000";

			await user.SignUpAsync();
		}
		/*
		async public void TestParseUser()
		{
			//var testObjects = new ParseUser ();
			var user = new ParseUser()
			{
				//Username = _user.,
				Password = "my pass",
				Email = "email@example.com"
			};

			// other fields can be set just like with ParseObject
			user["phone"] = "650-555-0000";

			await user.SignUpAsync();
		}
		*/

		async public void Login(string user, string password)
		{
			await ParseUser.LogInAsync (user, password);
		}
	
		async public void Register(string user, string password)
		{
			
			//await ParseUser.SaveAllAsync(user, password);


		}



















	}
}

