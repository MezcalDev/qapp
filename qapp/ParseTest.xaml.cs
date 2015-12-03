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
			App.ParseManager.TestParse ();
		}

		public void OnSignUp(object sender, EventArgs args)
		{
			App.ParseManager.TestSignUp ();
		}
	}
}

