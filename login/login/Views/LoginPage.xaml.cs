using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using login.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace login.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private async void Signup_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage());
        }


      
        private async void login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
      
    }
}