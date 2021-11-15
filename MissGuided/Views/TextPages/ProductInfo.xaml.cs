using System;
using System.Collections.Generic;
using System.Linq;
using MissGuided.Models;
using Xamarin.Forms;

namespace MissGuided.Views.TextPages
{
    public partial class ProductInfo : ContentPage
    {
        Product product;
        public ProductInfo()
        {
            InitializeComponent();
        }

        public ProductInfo(Product passedProduct)
        {
            InitializeComponent();
            product = passedProduct;
            lblDescription.Text = product.description;
            initSize();
        }

        void initSize()
        {
            string sizes = "available in:";
            List<string> arrSizes = product.sizes;

            for (int i = 0; i < arrSizes.Count(); i++)
            {
                sizes += " " + arrSizes.ElementAt(i);
            }

            lblSize.Text = sizes;
        }
    }
}
