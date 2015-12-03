using System;

using Xamarin.Forms;

namespace qapp
{
	public class App : Application
	{
		public static ParseManager ParseManager { get; set; }

		public App ()
		{
			// The root page of your application
			MainPage = new ParseTest ();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

