using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MissGuided.Views.CheckoutFormPages;

namespace MissGuided.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddressBookBlankPage : ContentPage
    {
        public AddressBookBlankPage()
        {
            InitializeComponent();
        }

        private void add_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddDeliveryAddress());
        }
    }
}