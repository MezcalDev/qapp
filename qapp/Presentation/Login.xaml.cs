using System;
using System.Collections.Generic;
using System.Net;

using Xamarin.Forms;

namespace qapp
{
	public partial class Login : ContentPage
	{
		class Constants {
			public const string Error = "Error";
			public const string UserNotFound = "The user doesn't exist";
		}
		public Login ()
		{
			InitializeComponent ();
		}

		async public void OnSignIn(object sender, EventArgs args)
		{
			try
			{
				await ParseManager.SharedInstance.Login (usernameEntry.Text, passwordEntry.Text);
			} catch(System.Net.WebException e) {
				if (e.Status == WebExceptionStatus.ProtocolError)
				{
					var response = e.Response as HttpWebResponse;
					if (response != null)
					{
						if (response.StatusCode == HttpStatusCode.NotFound) {
							DisplayAlert (Constants.Error, Constants.UserNotFound, qapp.Constants.UserStrings.OK);
						}
					}
					else
					{
						// no http status code available
					}
				}
				else
				{
					// no http status code available
				}
			}
		}

		public void Register(object sender, EventArgs args)
		{
			//this.Navigation.PushModalAsync(new NavigationPage(new Login()));
			this.Navigation.PushAsync (new NavigationPage (new Register ()));
		}
	}
}

