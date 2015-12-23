using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace qapp
{
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

		public void OnSignIn(object sender, EventArgs args)
		{
//			try
//			{
				ParseManager.SharedInstance.Login (usernameEntry.Text, passwordEntry.Text);
//			} catch(Exception e) {
//			}
		}

		public void Register(object sender, EventArgs args)
		{
			//this.Navigation.PushModalAsync(new NavigationPage(new Login()));
			this.Navigation.PushAsync (new NavigationPage (new Register ()));
		}
	}
}

