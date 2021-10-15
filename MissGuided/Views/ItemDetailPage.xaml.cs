using System.ComponentModel;
using Xamarin.Forms;
using MissGuided.ViewModels;

namespace MissGuided.Views
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
