using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new cal();
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
