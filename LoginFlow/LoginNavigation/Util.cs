using System;
using Xamarin.Forms;

namespace LoginNavigation
{
	public interface Util
	{
		async void OnSettingsButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SignUpPage());
		}
	}
}


