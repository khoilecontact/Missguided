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

namespace MissGuided
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
            ItemsAddedAsync();
        }
        async Task ItemsAddedAsync()
        {
            blankPage.IsVisible = false;
            Products itemsList = await CartAPI.shared.FetchCart();
            if (itemsList != null)
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
            Navigation.PushAsync(new CartPage());
        }

        void CheckOutBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            // push to checkout page
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
    }
}
