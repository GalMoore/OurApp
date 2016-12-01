using System;

using Xamarin.Forms;

namespace LoginNavigation
{
	public class SettingsPageCS : ContentPage
	{
		public SettingsPageCS()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

