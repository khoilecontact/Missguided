using System;
using System.Collections.Generic;
using MissGuided.Models;
using MissGuided.Services;
using MissGuided.ViewModels;
using Xamarin.Forms;

namespace MissGuided.Views
{
    public partial class ShelveItems : ContentPage
    {
        List<Product> originalProducts;
        ShelveItemsModel pageModel;
        string queryPath = "";
        public ShelveItems()
        {
            InitializeComponent();
        }

        List<Product> list = new List<Product>();
        List<string> sortOptions = new List<string>();


        public ShelveItems(List<Product> products, string queryString)
        {
            InitializeComponent();
            originalProducts = products;
            queryPath = queryString;
            if (originalProducts.Count <= 1)
            {
                productsLength.Text = originalProducts.Count.ToString() + " Item";
            }
            else
            {
                productsLength.Text = originalProducts.Count.ToString() + " Items";
            }
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

        async void sortPrk_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            // sort products
            string sortStatus = (string)sortPrk.SelectedItem;
            string query = queryPath + "&sort=" + sortStatus;
            List<Product> result = await ProductAPI.shared.FetchProducts(1, query);
            pageModel = new ShelveItemsModel(this, result);
            BindingContext = pageModel;
        }

        void filterBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FilterPage(queryPath));
        }
    }
}
