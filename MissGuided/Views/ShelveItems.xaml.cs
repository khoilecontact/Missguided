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
        List<string> sortOptions = new List<string>();


        public ShelveItems(List<Product> products)
        {
            InitializeComponent();
            originalProducts = products;
            pageModel = new ShelveItemsModel(this, originalProducts);
            BindingContext = pageModel;
            initPicker();
            //listProducts.ItemsSource = products;
        }

        void createList()
        {
            //list.Add(originalProducts);
        }

        void initPicker()
        {
            sortOptions.Add("Most wanted");
            sortOptions.Add("Price - low to high");
            sortOptions.Add("Price - high to low");
            sortPrk.ItemsSource = sortOptions;
            sortPrk.SelectedIndex = 0;
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }

        void sortPrk_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            // sort products 
        }

        void filterBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FilterPage());
        }
    }
}
