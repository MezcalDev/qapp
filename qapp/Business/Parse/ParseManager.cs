using System;

namespace qapp
{
	public class ParseManager
	{
		IParseStorage _storage;

		public ParseManager (IParseStorage parseStorage)
		{
			_storage = parseStorage;
		}

		public void TestParse() 
		{
			_storage.TestParse();
		}

		public void TestSignUp()
		{
			_storage.TestParseSignUp();
		}
	}
}

