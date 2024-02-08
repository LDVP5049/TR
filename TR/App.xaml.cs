using System;
using TR.Vista;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Vimc();
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
