using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace qapp
{
	public partial class Register : ContentPage
	{
		public Register ()
		{
			InitializeComponent ();
		}

		public void OnRegister(object sender, EventArgs args)
		{
			//			try
			//			{

			ParseManager.SharedInstance.Register(usernameNew.Text, passwordNew.Text);

			//			} catch(Exception e) {
			//			}
		}
	}
}

