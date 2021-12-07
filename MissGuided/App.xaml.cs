using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MissGuided.Services;
using MissGuided.Views;
using DLToolkit.Forms.Controls;
using MissGuided.Models;
using System.Collections.Generic;

namespace MissGuided
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            Database db = new Database();
            db.createDatabase();

            FlowListView.Init();
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
