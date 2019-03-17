using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TpXamarin.Views.CustomNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomNavigationView : NavigationPage
    {
        public CustomNavigationView()
        {
        }

        public CustomNavigationView(Page root) : base(root)
        {
        }
    }
}
