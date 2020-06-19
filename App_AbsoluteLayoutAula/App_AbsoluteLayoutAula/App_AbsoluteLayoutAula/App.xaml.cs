using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_AbsoluteLayoutAula
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AbsolutePage1();
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
