using System;
using Xamarin.Forms;

namespace LoginNavigation
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage()
		{
			InitializeComponent();
		}

		void OnSliderValueChanged(object sender,
								  ValueChangedEventArgs args)
		{
			valueLabel.Text = ((Slider)sender).ToString();
		}

	}
}
