using System;
using System.Threading.Tasks;
using TpXamarin.Services;
using TpXamarin.Views.ArticleList;
using TpXamarin.Views.SplashScreen;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
