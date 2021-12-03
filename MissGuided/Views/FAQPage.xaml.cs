using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MissGuided.Views.TextPages;

namespace MissGuided.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FAQPage : ContentPage
    {
        public FAQPage()
        {
            InitializeComponent();
        }
        private void cart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }
        private void salesTax_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SalesTaxPage());
        }
        private void whatisKlamar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WhatIsKlarmaPage());
        }
        private void whereismyorder_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WhereIsMyOrderPage());
        }
        private void haveyourecievedmyreturn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HaveYouReceivedMyReturnPage());
        }
        private void howdoIreturnanItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HowDoIReturnAnItemPage());
        }
        private void canIchangemyadddress_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CanIChangeMyAddressPage());
        }
        private void whatsizeshouldIorder_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WhatSizeShouldIOrderPage());
        }
    }
}