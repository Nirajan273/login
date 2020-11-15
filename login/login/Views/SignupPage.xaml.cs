using login.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        async void Add_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(firstnameEntry.Text) && !string.IsNullOrWhiteSpace(ageEntry.Text))
            {
                await App.Database.SavePersonAsync(new Person
                {
                    FirstName = firstnameEntry.Text,
                    LastName = lastnameEntry.Text,
                    Email = emailEntry.Text,
                    Password = passwordEntry.Text,
                    Age = int.Parse(ageEntry.Text)
                });

                firstnameEntry.Text = ageEntry.Text = lastnameEntry.Text = emailEntry.Text = passwordEntry.Text = string.Empty;
                listView.ItemsSource = await App.Database.GetPeopleAsync();

                await Navigation.PushAsync(new ProfilePage());
            }

        }
        public SignupPage()
        {
            InitializeComponent();
           
        }


    }
}