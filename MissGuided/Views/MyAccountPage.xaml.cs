﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MissGuided.Models;

namespace MissGuided.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyAccountPage : ContentPage
    {
        public MyAccountPage(User user)
        {
            InitializeComponent();
        }

        private void save_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Message", "Update successfully", "OK");
        }
    }
}