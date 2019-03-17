using System;
using System.Collections.Generic;
using TpXamarin.Models;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TpXamarin.JLTApi;
using Refit;
using TpXamarin.Views.ArticleDetail;
using Xamarin.Forms;

namespace TpXamarin.Views.ArticleList
{
    class ArticleListViewModel : BaseViewModel
    {
        private List<Article> _articles;
        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
            set
            {
                this._articles = value;
                OnPropertyChanged("Articles");
            }
        }
        
        private String url = "http://api.blog.juleslaurent.fr/articles";
        public HttpClient httpClient = new HttpClient();
      
        public ArticleListViewModel()
        {
            this.Load();
        }

        public async void Load()
        {
            this.Articles = await RestService.For<IJLTApi>("http://api.blog.juleslaurent.fr").GetArticles();
        }

        public ICommand SelectItemCommand => new Command<Article>((Article article) =>
            {
                Console.WriteLine("OK");
                this.NavigationService.NavigateToAsync<ArticleDetailViewModel>();
            });
    }
}
