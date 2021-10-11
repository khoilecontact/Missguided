using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MissGuided.Views
{
    public partial class ShopPage : ContentPage
    {
        public ShopPage()
        {
            InitializeComponent();
        }

        void cart_clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }
    }
}
