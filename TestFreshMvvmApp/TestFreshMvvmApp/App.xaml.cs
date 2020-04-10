using System;
using FreshMvvm;
using TestFreshMvvmApp.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestFreshMvvmApp
{
	public partial class App : Application
	{
		public App()
		{
			var contactList = FreshPageModelResolver.ResolvePageModel<ContactListPageModel>(null);
			var navContainer = new FreshNavigationContainer(contactList);
			MainPage = navContainer;
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
