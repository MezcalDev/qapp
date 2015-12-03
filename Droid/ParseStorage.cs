using System;
using Parse;

namespace qapp.Droid
{
	public class ParseStorage : IParseStorage
	{
		public ParseStorage ()
		{
			ParseClient.Initialize (Constants.AppId, Constants.NetID);
		}

		async public void TestParse()
		{
			var testObject = new ParseObject ("TestObject");
			testObject ["foo"] = "bar";
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

	}
}

