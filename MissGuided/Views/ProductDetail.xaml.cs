using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using MissGuided.Models;
using MissGuided.Views.TextPages;
using Xamarin.Forms;

namespace MissGuided.Views
{

    public partial class ProductDetail : ContentPage
    {
        Product product;
        public ICommand CarouselItemTapped { get; set; }

        public ProductDetail()
        {
            InitializeComponent();
            initScreen();
            initSuggestedProducts();
        }

        public ProductDetail(Product passedProduct)
        {
            InitializeComponent();
            product = passedProduct;
            initScreen();
            initSuggestedProducts();
            CarouselItemTapped= new Xamarin.Forms.Command((selectItem)=>{
                Product selectedProduct = (Product)selectItem;
                Navigation.PushAsync(new ProductDetail(selectedProduct));
            });
        }

        async void initScreen()
        {
            if (product == null) {
                List<Product> products = await APICaller.shared.FetchProductsSwipe(1);
                product = products[1];
            } 

            imgProduct.Source = product.images[0];
            lbl_name.Text = product.name;
            lbl_sale_price.Text = product.salePrice;
            lbl_price.Text = product.price;


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
            List<Product> products = await APICaller.shared.FetchProductsSwipe(1);
            product = products[1];
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
