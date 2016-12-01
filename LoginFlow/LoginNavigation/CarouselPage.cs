using System;

using Xamarin.Forms;

namespace LoginNavigation
{
	public class CarouselPage : ContentPage
	{
		public CarouselPage()
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

