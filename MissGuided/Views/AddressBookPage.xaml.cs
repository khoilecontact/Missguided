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
        Database db = new Database();
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

        private void addressesLst_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Address address = (Address)e.SelectedItem;
            OnAlertYesNoClicked(address);
        }
        async void OnAlertYesNoClicked(Address address)
        {
            bool choice = await DisplayAlert("Question?", "Would you like to delete this address?", "Yes", "No");
            if (choice)
            {
                db.delAnAddress(address);
                await DisplayAlert("Message", "Delete sucessfully", "OK");
                InitAddressList();
            }
            else
            {
                await DisplayAlert("Message", "Delete failed", "OK");
                InitAddressList();
            }
        }
    }
}