using Multiselect;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LoginNavigation
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage()
		{
			InitializeComponent();
            QualificationPicker.Items.Add("BSc");
            QualificationPicker.Items.Add("MSc");
            QualificationPicker.Items.Add("MPhil");
            QualificationPicker.Items.Add("PhD");
            
            
            /*
            StackLayout myStackLayout = new StackLayout {
                Children = {
                    QualificationPicker,
                    qualText
                },
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            */
        }

        SelectMultipleBasePage<CheckItem> multiPage;
        async void OnClick(object sender, EventArgs ea)
        {
            var items = new List<CheckItem>();
            items.Add(new CheckItem { Name = "Togalog" });
            items.Add(new CheckItem { Name = "Farsi" });
            items.Add(new CheckItem { Name = "Archi" });
            items.Add(new CheckItem { Name = "Yupik" });
            items.Add(new CheckItem { Name = "Pawnee" });
            items.Add(new CheckItem { Name = "Xhosa" });
            items.Add(new CheckItem { Name = "Rotokas" });
            items.Add(new CheckItem { Name = "Piraha" });

            if (multiPage == null)
                multiPage = new SelectMultipleBasePage<CheckItem>(items) { Title = "Check all that apply" };

            await Navigation.PushAsync(multiPage);
        }

        async void OnMainPageButtonClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new MainPage(), this);
            await Navigation.PopAsync();
        }   

    }
}
