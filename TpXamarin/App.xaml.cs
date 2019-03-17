using System;
using System.Threading.Tasks;
using TpXamarin.Services;
using TpXamarin.Views.ArticleList;
using TpXamarin.Views.SplashScreen;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TpXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override async void OnStart()
        {
            MainPage = new SplashScreenView();
            AppCenter.Start("android=330fab63-49a2-4cbc-9523-d922c8e3d685;", typeof(Analytics), typeof(Crashes));
            await Task.Delay(2000);
            await new NavigationService().InitializeAsync();
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
