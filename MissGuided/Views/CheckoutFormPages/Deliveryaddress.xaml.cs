using System;
using System.Collections.Generic;
using System.Linq;
using MissGuided.Models;
using MissGuided.Services;
using Xamarin.Forms;

namespace MissGuided.Views.CheckoutFormPages
{
    public partial class Deliveryaddress : ContentPage
    {
        public Deliveryaddress()
        {
            InitializeComponent();
            initView();
        }

        void initView()
        {
            Database db = new Database();
            List<Address> addresses = db.getAddresses();
            if (addresses.Count() == 0)
            {
                Navigation.PushAsync(new AddDeliveryAddress());
            }
            lst_address.ItemsSource = addresses;
        }

        void btn_add_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddDeliveryAddress());
        }
    }
}
