using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using MissGuided.Models;
using MissGuided.Services;
using Xamarin.Forms;

namespace MissGuided.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            addBanner();
            addBannerGrid();
            addBannerBottom();
            //testAPI();
        }

        List<Banner> bannerListTop = new List<Banner>();
        List<Banner> bannerGrid = new List<Banner>();
        List<Banner> bannerListBottom = new List<Banner>();

        void cart_clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CartPageBlank());
        }

        string[] bannerSrc = new string[]
        {
            "https://media.missguided.com/i/missguided/Kids_28_10_mobile.webp?w=767&qlt=70",
            "https://media.missguided.com/i/missguided/Carli_Bybel_26_10_mobile.webp?w=767&qlt=70",
            "https://media.missguided.com/i/missguided/Party_UK_26_10_mobile.webp?w=767&qlt=70",
        };

        string[] gridBanner = new string[]
        {
            "https://media.missguided.com/i/missguided/DD930356_01?fmt=jpeg&fmt.jpeg.interlaced=true&$product-page__main--1x$",
            "https://media.missguided.com/i/missguided/VX1788335_01?fmt=jpeg&fmt.jpeg.interlaced=true&$product-page__main--1x$",
            "https://media.missguided.com/i/missguided/R9347415_01?fmt=jpeg&fmt.jpeg.interlaced=true&$product-page__main--1x$",
            "https://media.missguided.com/i/missguided/TJF26868_01?fmt=jpeg&fmt.jpeg.interlaced=true&$product-page__main--1x$",
        };

        string[] bannerBottomSrc = new string[]
        {
            "https://media.missguided.com/i/missguided/MS110083_01?fmt=jpeg&fmt.jpeg.interlaced=true&$product-page__main--1x$",
            "https://media.missguided.com/i/missguided/SBF1614025_01?fmt=jpeg&fmt.jpeg.interlaced=true&$product-page__main--1x",
            "https://media.missguided.com/i/missguided/O1448251_01?fmt=jpeg&fmt.jpeg.interlaced=true&$product-page__main--1x$",
        };

        void addBanner()
        {
            bannerListTop.Add(new Banner
            {
                src = bannerSrc[0],
                link = "",
            });

            bannerListTop.Add(new Banner
            {
                src = bannerSrc[1],
                link = "",
            });

            bannerListTop.Add(new Banner
            {
                src = bannerSrc[2],
                link = "",
            });

            Img2.Source = bannerListTop[0].src;
            Img3.Source = bannerListTop[1].src;
            Img4.Source = bannerListTop[2].src;
        }

        void addBannerGrid()
        {
            bannerGrid.Add(new Banner
            {
                src = gridBanner[0],
                link = "",
            });

            bannerGrid.Add(new Banner
            {
                src = gridBanner[1],
                link = "",
            });

            bannerGrid.Add(new Banner
            {
                src = gridBanner[2],
                link = "",
            });

            bannerGrid.Add(new Banner
            {
                src = gridBanner[3],
                link = "",
            });

            Grid1.Source = bannerGrid[0].src;
            Grid2.Source = bannerGrid[1].src;
            Grid3.Source = bannerGrid[2].src;
            Grid4.Source = bannerGrid[3].src;
        }

        void addBannerBottom()
        {
            bannerListBottom.Add(new Banner
            {
                src = bannerBottomSrc[0],
                link = "",
            });

            bannerListBottom.Add(new Banner
            {
                src = bannerBottomSrc[1],
                link = "",
            });

            bannerListBottom.Add(new Banner
            {
                src = bannerBottomSrc[2],
                link = "",
            });

            Img5.Source = bannerListBottom[0].src;
            Img6.Source = bannerListBottom[1].src;
            Img7.Source = bannerListBottom[2].src;
        }

        async void refreshView_Refreshing(System.Object sender, System.EventArgs e)
        {
            await Task.Delay(3000);
            refreshView.IsRefreshing = false;
        }

        async void searchBar_SearchButtonPressed(System.Object sender, System.EventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            List<Product> searchResult = await SearchAPI.shared.FetchProducts(1, searchBar.Text.ToString());

            /// Product product_one = content[0];
            /// PushAsync to ShopUI
        }
    }
}
