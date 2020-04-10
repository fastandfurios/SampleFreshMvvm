using System.Collections.Generic;
using FreshMvvm;
using TestFreshMvvmApp.Models;

namespace TestFreshMvvmApp.PageModels
{
	public class ContactListPageModel : FreshBasePageModel
	{
		public ContactListPageModel()
		{
			
		}

		public List<Contact> ContactList
		{
			get;
			set;
		}

		public Contact SelectedContact
		{
			get => null;
			set
			{
				CoreMethods.PushPageModel<ContactPageModel>(value);
				RaisePropertyChanged();
			}
		}

		public override void Init(object initData)
		{
			base.Init(initData);
			ContactList = new List<Contact>
			{
				new Contact
				{
					Name = "Петя",
					Number = "89215668879"
				},
				new Contact
				{
					Name = "Таня",
					Number = "89995688521"
				}
			};
		}
	}
}
