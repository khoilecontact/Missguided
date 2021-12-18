using System;
using System.Collections.Generic;
using Syncfusion.XForms.Buttons;
using MissGuided.Views;
using Xamarin.Forms;
using System.Windows.Input;
using MissGuided.Models;
using MissGuided.Services;

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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string title = (string)((Button)sender).Text.Split(' ')[0];


            string query = "categories="+title;

            List<Product> result = await ProductAPI.shared.FetchProducts(1, query);

            if (result != null)
            {
                await Navigation.PushAsync(new ShelveItems(result, query));
            }
            else
            {
                await Navigation.PushAsync(new BlankShelvesItem());
            }
        }
    }
}
