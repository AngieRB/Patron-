using System;
using ViewMVM.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace ViewMVM
{
  
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NovelaView();
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

