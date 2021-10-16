﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MissGuided.Models;
using MLToolkit.Forms.SwipeCardView.Core;
using Xamarin.Forms;

namespace MissGuided.Views
{
    public partial class SwipePage : ContentPage
    {
        public ObservableCollection<Product> _Products = new ObservableCollection<Product>();

        public SwipePage()
        {
            InitializeComponent();
            CardBinding();
        }

        public void CardBinding()
        {
            _Products.Add(new Product()
            {
                name = "Phat",
                price = "$30",
                salePrice = "$10",
                categories = new String[2] { "pant", "lower body" },
                description = "Description",
                sizes = new String[2] { "15", "20" },
                images = new string[1] { "app_logo.jpg" }
            });

            _Products.Add(new Product()
            {
                name = "Ngu",
                price = "$20",
                salePrice = "$9",
                categories = new String[2] { "pant", "lower body" },
                description = "Description",
                sizes = new String[2] { "15", "20" },
                images = new string[1] { "app_logo.jpg" }
            });

            _Products.Add(new Product()
            {
                name = "Khoi Ng",
                price = "$10",
                salePrice = "$5",
                categories = new String[2] { "pant", "lower body" },
                description = "Description",
                sizes = new String[2] { "15", "20" },
                images = new string[1] { "app_logo.jpg" }
            });

            _Products.Add(new Product()
            {
                name = "Phat",
                price = "$30",
                salePrice = "$10",
                categories = new String[2] { "pant", "lower body" },
                description = "Description",
                sizes = new String[2] { "15", "20" },
                images = new string[1] { "app_logo.jpg" }
            });

            _Products.Add(new Product()
            {
                name = "Ngu",
                price = "$20",
                salePrice = "$9",
                categories = new String[2] { "pant", "lower body" },
                description = "Description",
                sizes = new String[2] { "15", "20" },
                images = new string[1] { "app_logo.jpg" }
            });

            _Products.Add(new Product()
            {
                name = "Khoi Ng",
                price = "$10",
                salePrice = "$5",
                categories = new String[2] { "pant", "lower body" },
                description = "Description",
                sizes = new String[2] { "15", "20" },
                images = new string[1] { "app_logo.jpg" }
            });

            SwipeView.ItemsSource = _Products;
            BindingContext = this;

            var item = (Product)SwipeView.TopItem;
            lbl_name.Text = item.name;
            if (item.salePrice != null)
            {
                lbl_price.Text = "US" + item.salePrice + " " + "US" + item.price;
            }
            else
            {
                lbl_price.Text = "US" + item.price;
            }
        }

        public ObservableCollection<Product> Product
        {
            get => _Products;
            set
            {
                _Products = value;
            }
        }

        void OnSwiped(object sender, SwipedCardEventArgs e)
        {

            var item = (Product)SwipeView.TopItem;
            lbl_name.Text = item.name;
            if (item.salePrice != null)
            {
                lbl_price.Text = "US" + item.salePrice + " " + "US" + item.price;
            } else
            {
                lbl_price.Text = "US" + item.price;
            }
            

            switch (e.Direction)
            {
                case SwipeCardDirection.Right:
                    break;
                case SwipeCardDirection.Left:
                    break;
            }
        }


    }
}
