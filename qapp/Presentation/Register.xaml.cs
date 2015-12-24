using System;
using System.Collections.Generic;
using Parse;
using System.Windows.Input;

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

			//MessageUI ("tst");
			//MessageBox.Show("Mensaje personalizado");
			//Console.WriteLine(usernameNew.Text);
			Console.WriteLine("Hola");
		

			ParseManager.SharedInstance.Register(usernameNew.Text, passwordNew.Text);

			//			} catch(Exception e) {
			//			}
		}
	}
}

