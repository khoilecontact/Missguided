using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MissGuided.Models;

namespace MissGuided
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
            ItemsAdded();
        }
        List<Item> itemsList = new List<Item>();
        void ItemsAdded()
        {
            itemsList.Add(new Item { Img = "bag.png", Description = "Cai quan que gi ne", SalePrice = "????"});
            CartLst.ItemsSource = itemsList;
        }

        private void edit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }
    }
}
