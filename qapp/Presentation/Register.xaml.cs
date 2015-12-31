using System;
using System.Collections.Generic;
using Parse;
using System.Net;

using Xamarin.Forms;

namespace qapp
{
	public partial class Register : ContentPage
	{

		public Register ()
		{
			InitializeComponent ();
		}

		async public void OnRegister(object sender, EventArgs args)
		{
			try
			{
				await ParseManager.SharedInstance.Register(usernameNew.Text, passwordNew.Text);
				//await this.Navigation.PopToRootAsync(true); //No show error but not work
				await this.Navigation.PopAsync();
				//await Navigation.PopModalAsync(true); //Show error and not work

			} catch(System.Net.WebException e) {

				var response = e.Response as HttpWebResponse;

				if (response.StatusCode == HttpStatusCode.BadRequest) {
					await DisplayAlert (qapp.Constants.UserStrings.Error, qapp.Constants.UserStrings.UserFound, qapp.Constants.UserStrings.OK);
				} else {
					await DisplayAlert ("Error"," Error not found" ,qapp.Constants.UserStrings.OK);

				}
		}
	   }
   }
}
