using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TpXamarin.Views.ArticleList
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ArticleList : ContentPage
	{
		public ArticleList ()
		{
			InitializeComponent();
            this.BindingContext = new ArticleListViewModel();
		}

		
	}
}