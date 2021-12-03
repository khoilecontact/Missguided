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
        public List<Product> _Products = new List<Product>();

        public WishlistPage()
        {
            InitializeComponent();
            initView();
        }

        async void initView()
        {
            string email = Preferences.Get("userEmail", "none");
            if (email == "none" || email == null)
            {
                await Navigation.PushAsync(new WishlistPageBlank());
                return;
            }

            _Products = await APICaller.shared.GetUserWishlist();
            //_Products = await APICaller.shared.FetchProductsSwipe(1);

            lst_wishlist.ItemsSource = _Products;

            int productsCount = _Products.Count();

            if (productsCount == 0 || _Products == null)
            {
                await Navigation.PushAsync(new WishlistPageBlank());

            }
            else if (productsCount == 1)
            {
                lbl_total_products.Text = Convert.ToString(productsCount) + " Item";
            }
            else
            {
                lbl_total_products.Text = productsCount.ToString() + " Items";
            }
        }

        public List<Product> Product
        {
            get => _Products;
            set
            {
                _Products = value;
            }
        }

        async void btn_remove_Clicked(System.Object sender, System.EventArgs e)
        {
            string selectedProductId = (string)((Button)sender).BindingContext;
            bool result = await APICaller.shared.RemoveFromWishlist(selectedProductId);

            if (result)
            {
                _Products = await APICaller.shared.GetUserWishlist();

                lst_wishlist.ItemsSource = _Products;

                int productsCount = _Products.Count();

                if (productsCount == 0 || _Products == null)
                {
                    await Navigation.PushAsync(new WishlistPageBlank());

                }
                else if (productsCount == 1)
                {
                    lbl_total_products.Text = Convert.ToString(productsCount) + " Item";
                }
                else
                {
                    lbl_total_products.Text = productsCount.ToString() + " Items";
                }
            }
        }

        async void btn_addToBag_Clicked(System.Object sender, System.EventArgs e)
        {
            string selectedProductId = (string)((Button)sender).BindingContext;
            bool result = await CartAPI.shared.AddToCart(selectedProductId);
            //bool resultRemoveWishlist = await APICaller.shared.RemoveFromWishlist(selectedProductId);
        }

        void cart_clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }
    }
}
