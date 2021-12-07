using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MissGuided.Models;
using MissGuided.Services;
using MissGuided.Views;
using Xamarin.Essentials;

namespace MissGuided
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        bool showDelBtn;
        public CartPage()
        {
            InitializeComponent();
            showDelBtn = false;
            ItemsAddedAsync();
        }

        async Task ItemsAddedAsync()
        {
            blankPage.IsVisible = false;
            Products itemsList = await CartAPI.shared.FetchCart();
            if (itemsList.pLength != 0)
            {
                blankPage.IsVisible = false;
                CartLst.IsVisible = true;
                CartBoard.IsVisible = true;
                CartLst.ItemsSource = itemsList.cart;
                pLength.Text = itemsList.pLength.ToString()+" items";
                totalPrice.Text = itemsList.total;
            }
            else
            {
                CartLst.IsVisible = false;
                CartBoard.IsVisible = false;
                blankPage.IsVisible = true;
                //await Navigation.PushAsync(new CartPageBlank());
            }
        }

        private void edit_Clicked(object sender, EventArgs e)
        {
            showDelBtn = true;
        }

        void CheckOutBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CheckouPage());
        }

        void CartLst_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (CartLst.SelectedItem != null)
            {
                Product product = (Product)CartLst.SelectedItem;
                Navigation.PushAsync(new ProductDetail(product));
            }
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ShopPage());
        }

        async void Remove_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            string selectedProductId = (string)((Button)sender).BindingContext;
            bool result = await CartAPI.shared.RemoveFromCart(selectedProductId);

            if (result)
            {
                Products _Products = await CartAPI.shared.FetchCart();

                CartLst.ItemsSource = _Products.cart;
                pLength.Text = _Products.pLength.ToString() + " items";
                totalPrice.Text = _Products.total;

                int productsCount = _Products.cart.Count();

                if (productsCount == 0 || _Products == null)
                {
                    CartLst.IsVisible = false;
                    CartBoard.IsVisible = false;
                    blankPage.IsVisible = true;

                }
                else if (productsCount == 1)
                {
                    pLength.Text = Convert.ToString(productsCount) + " Item";
                }
                else
                {
                    pLength.Text = productsCount.ToString() + " Items";
                }
            } else
            {
                CartLst.IsVisible = false;
                CartBoard.IsVisible = false;
                blankPage.IsVisible = true;
            }
        }
    }
}
