using System.ComponentModel;
using Xamarin.Forms;
using login.ViewModels;

namespace login.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}