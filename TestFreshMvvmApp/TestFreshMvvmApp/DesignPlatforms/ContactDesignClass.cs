using Xamarin.Forms;
using Color = System.Drawing.Color;

namespace TestFreshMvvmApp.DesignPlatforms
{
	static class ContactDesignClass
	{
		public static Color BackgroundColor;
		public static string Font;

		static ContactDesignClass()
		{
			if (Device.Android == Device.RuntimePlatform)
			{
				BackgroundColor = Color.Blue;
				Font = "Montserrat-Bold.ttf#Montserrat-Bold";
			}
		}
	}
}
