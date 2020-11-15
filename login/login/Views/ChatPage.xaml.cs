using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace login.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatPage : ContentPage
    {
        public ChatPage()
        {
            InitializeComponent();
        }

        private async void Send_Clicked(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrWhiteSpace(chatDialogEntry.Text))
            {
                await App.Database.SaveScriptAsync(new Script
                {
                    ChatName = chatnameEntry.Text,
                    ChatDialog= chatDialogEntry.Text

                });

                chatDialogEntry.Text = "";
                listView.ItemsSource = await App.Database.GetScriptAsync();

            }
        }
    }
}