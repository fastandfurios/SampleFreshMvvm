using System;
using FreshMvvm;
using TestFreshMvvmApp.Models;

namespace TestFreshMvvmApp.PageModels
{
	public class ContactPageModel : FreshBasePageModel
	{
		public ContactPageModel()
		{
			
		}

		public Contact Contact
		{
			get;
			set;
		}

		public override void Init(object initData)
		{
			base.Init(initData);
			Contact = initData as Contact;
		}

		protected override void ViewIsAppearing(object sender, EventArgs e)
		{
			base.ViewIsAppearing(sender, e);
			CoreMethods.DisplayAlert("Страница контакта", Contact.Name, "OK");
		}
	}
}
