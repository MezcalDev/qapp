using System;
using Parse;
using System.Threading.Tasks;

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

		async public Task<User> Login(string userName, string password)
		{
			try {
				ParseUser parseUser = await ParseUser.LogInAsync (userName, password);
				User user = new User(parseUser);
				return user;
			} catch (Exception e) {

				Console.WriteLine ("exception");
				throw e;
			}
		}
	
		async public Task Register(string user, string password)
		{
			try{
			//await ParseUser.SaveAllAsync(user, password);
			var users = new ParseUser () {
				Username = user,//"email@example.com",
				Password = password,//"my pass",
				Email = user//"email@example.com"
			};

			// other fields can be set just like with ParseObject
			//user ["phone"] = "415-392-0202";

			await users.SignUpAsync ();
			}catch (Exception e) {

				Console.WriteLine ("exception2");
				throw e;
			}


		}

	



	}
}

