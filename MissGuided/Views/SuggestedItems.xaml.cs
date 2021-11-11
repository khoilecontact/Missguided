using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using MissGuided.Models;
using Xamarin.Forms;

namespace MissGuided.Views
{
    public partial class SuggestedItems : ContentPage
    {
        public ICommand ItemTappedCommand
        {
            get
            {
                return new Command((selectedItem) =>
                {
                    Navigation.PushAsync(new ProductDetail((Product)selectedItem));
                });
            }
        }

        public SuggestedItems()
        {
            InitializeComponent();
            initSuggestedProducts();
        }

        async void initSuggestedProducts()
        {
            List<Product> products = await APICaller.shared.FetchProductsSwipe(3);

            foreach (Product product in products)
            {
                if (product.salePrice == null)
                {
                    product.salePrice = "none";
                }
            }

            flwLstViewItems.FlowItemsSource = products;

            flwLstViewItems.FlowItemTappedCommand = ItemTappedCommand;

        }
    }
}
