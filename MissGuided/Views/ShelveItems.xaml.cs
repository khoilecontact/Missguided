using System;
using System.Collections.Generic;
using MissGuided.Models;
using MissGuided.ViewModels;
using Xamarin.Forms;

namespace MissGuided.Views
{
    public partial class ShelveItems : ContentPage
    {
        List<Product> originalProducts;
        ShelveItemsModel pageModel;
        public ShelveItems()
        {
            InitializeComponent();
        }

        List<Product> list = new List<Product>();

        public ShelveItems(List<Product> products)
        {
            InitializeComponent();
            originalProducts = products;
            pageModel = new ShelveItemsModel(this, originalProducts);
            BindingContext = pageModel;
            //listProducts.ItemsSource = products;
        }

        void createList()
        {
            //list.Add(originalProducts);
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }
    }
}
