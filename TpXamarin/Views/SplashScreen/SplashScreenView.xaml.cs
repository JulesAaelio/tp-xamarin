using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TpXamarin.Views.SplashScreen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreenView : ContentPage
    {
        public SplashScreenView()
        {
            InitializeComponent();
            this.BindingContext = new SplashScreenViewModel();
        }
    }
}
