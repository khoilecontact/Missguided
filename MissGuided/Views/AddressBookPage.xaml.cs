using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MissGuided.Views.CheckoutFormPages;
using MissGuided.Services;
using MissGuided.Models;

namespace MissGuided.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddressBookPage : ContentPage
    {
        public AddressBookPage()
        {
            InitializeComponent();
            InitAddressList();
        }
        private void add_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddDeliveryAddress());
        }
        void InitAddressList()
        {
            Database db = new Database();
            List<Address> addresses = db.getAddresses();
            if(addresses.Count() == 0)
            {
                BlankPage.IsVisible = true;
                addressesLst.IsVisible = false;
            }
            else
            {
                BlankPage.IsVisible = false;
                addressesLst.IsVisible = true;
                addressesLst.ItemsSource = addresses;
            }
        }
    }
}