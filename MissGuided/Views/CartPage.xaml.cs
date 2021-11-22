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
            List<Product> itemsList = await CartAPI.shared.FetchCart();
            if (itemsList != null)
            {
                CartLst.ItemsSource = itemsList;
            }
            else
            {
                Navigation.PushAsync(new CartPageBlank());
            }
        }

        private void edit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }
    }
}
