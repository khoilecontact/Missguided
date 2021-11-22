using System;
using System.Collections.Generic;
using System.Linq;
using MissGuided.Models;
using MissGuided.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MissGuided.Views
{
    public partial class WishlistPage : ContentPage
    {
        public WishlistPage()
        {
            InitializeComponent();
            initView();
        }

        async void initView()
        {
            List<Product> products = await APICaller.shared.GetUserWishlist();
            lst_wishlist.ItemsSource = products;
            int productsCount = products.Count;
            if (productsCount == 0 || products == null)
            {
                Navigation.PushAsync(new WishlistPageBlank());
            }
                else if (productsCount == 1)
            {
                lbl_total_products.Text = products.Count.ToString() + "Item";
            }
                else
            {
                lbl_total_products.Text = products.Count.ToString() + "Items";
            }
        }

        async void btn_remove_Clicked(System.Object sender, System.EventArgs e)
        {
            string selectedProductId = (string)((Button)sender).BindingContext;
            bool result = await APICaller.shared.RemoveFromWishlist(selectedProductId);
        }

        async void btn_addToBag_Clicked(System.Object sender, System.EventArgs e)
        {
            string selectedProductId = (string)((Button)sender).BindingContext;
            bool result = await CartAPI.shared
        }
    }
}
