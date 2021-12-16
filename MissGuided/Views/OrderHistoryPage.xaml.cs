using MissGuided.Models;
using MissGuided.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MissGuided.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderHistoryPage : ContentPage
    {
        bool showDelBtn;
        public OrderHistoryPage()
        {
            InitializeComponent();
            showDelBtn = false;
            _ = ItemsAddedAsync();
        }

        async Task ItemsAddedAsync()
        {
            blankPage.IsVisible = false;
            Products itemsList = await CartAPI.shared.FetchCart();
            if (itemsList.pLength != 0)
            {
                blankPage.IsVisible = false;
                OrderedLst.IsVisible = true;
                OrderedBoard.IsVisible = true;
                OrderedLst.ItemsSource = itemsList.cart;
                pLength.Text = itemsList.pLength.ToString() + " items";
                totalPrice.Text = itemsList.total;
            }
            else
            {
                OrderedLst.IsVisible = false;
                OrderedBoard.IsVisible = false;
                blankPage.IsVisible = true;
                //await Navigation.PushAsync(new CartPageBlank());
            }
        }
        private void OrderedLst_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (OrderedLst.SelectedItem != null)
            {
                Product product = (Product)OrderedLst.SelectedItem;
                Navigation.PushAsync(new ProductDetail(product));
            }
        }

        private void fillmeup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShopPage());
        }


    }
}