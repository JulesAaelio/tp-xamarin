using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TpXamarin.Views.CustomNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomNavigationView : NavigationPage
    {
        public CustomNavigationView()
        {
            InitializeComponent();
        }

        public CustomNavigationView(Page root) : base(root)
        {
            InitializeComponent();
        }
    }
}
