using System;
using System.Collections.Generic;
using Parse;
using System.Net;
using Xamarin.Forms;

namespace qapp
{
	public partial class QuestionPage : ContentPage 
	{
		
		public QuestionPage ()
		{
			InitializeComponent ();
		}

		async public void OnSave(object sender, EventArgs args)
		{
			await ParseManager.SharedInstance.CreateQuestion (question.Text);
			question.Text = "";

		}
			
	}
}

