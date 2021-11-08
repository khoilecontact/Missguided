using System;
using System.Collections.Generic;
using System.Linq;
using MissGuided.Models;
using MissGuided.Views.TextPages;
using Xamarin.Forms;

namespace MissGuided.Views
{
    public partial class ProductDetail : ContentPage
    {
        Product product;

        public ProductDetail()
        {
            InitializeComponent();
            testing();
            initSize();
            initSuggestedProducts();
        }

        public ProductDetail(Product passedProduct)
        {
            InitializeComponent();
            //product = passedProduct;
            testing();
            initSize();
            initSuggestedProducts();
        }

        void initSize()
        {
            string sizes = "available in:";
            List<string> arrSizes = product.sizes;

            for (int i=0 ; i < arrSizes.Count(); i++)
            {
                sizes += " " + arrSizes.ElementAt(i);
            }

            lblSize.Text = sizes;
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

            crslSuggestedProduct.ItemsSource = products;

        }

        async void testing()
        {
            List<Product> products = await APICaller.shared.FetchProductsSwipe(3);
            product = products.ElementAt(1);
        }

        void btnInfo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ProductInfo(product));
        }

        void btnSizeGuide_Clicked(object sender, System.EventArgs e)
        {
        }

        void btnDelivery_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ShippingTextPage());
        }

        void btnViewAll_Clicked(System.Object sender, System.EventArgs e)
        {
        }
    }
}
