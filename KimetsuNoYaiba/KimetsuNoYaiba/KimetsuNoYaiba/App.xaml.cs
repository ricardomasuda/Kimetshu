using System;
using KimetsuNoYaiba.View.Home;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace KimetsuNoYaiba
{
    public partial class App : Application
    {
        public static NavigationPage NavPage { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            NavPage = new NavigationPage(new MainPage());
            MainPage = NavPage;
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}