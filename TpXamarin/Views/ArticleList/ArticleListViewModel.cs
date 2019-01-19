using System;
using System.Collections.Generic;
using System.Text;
using TpXamarin.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.ComponentModel;
using TpXamarin.JLTApi;
using Refit;

namespace TpXamarin.ListPage
{
    class ArticleListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private List<Article> articles;
        public List<Article> Articles
        {
            get
            {
                return articles;
            }
            set
            {
                this.articles = value;
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
    }
}
