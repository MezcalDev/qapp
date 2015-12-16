using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace qapp
{
	public partial class ParseTest : ContentPage
	{
		public ParseTest ()
		{
			InitializeComponent ();
		}

		public void OnTest(object sender, EventArgs args)
		{
			ParseManager.SharedInstance.TestParse ();
		}

		public void OnSignUp(object sender, EventArgs args)
		{
			ParseManager.SharedInstance.TestParseSignUp ();
		}
	}
}

