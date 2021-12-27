using System;
using System.Collections.Generic;
using System.Linq;
using MissGuided.Models;
using Xamarin.Forms;

namespace MissGuided.Views
{
    public partial class WishlistPageBlank : ContentPage
    {
        public WishlistPageBlank()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            List<Product> products = await APICaller.shared.GetUserWishlist();
            if (products.Count() > 0)
            {
                await Navigation.PopAsync();
            }
        }
        void cart_clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ShopPage());
        }
    }
}
