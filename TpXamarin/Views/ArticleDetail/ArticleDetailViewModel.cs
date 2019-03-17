using System;
using System.Threading.Tasks;
using TpXamarin.Models;
using Xamarin.Forms;

namespace TpXamarin.Views.ArticleDetail
{
    public class ArticleDetailViewModel: BaseViewModel
    {
        
        private Article _article;
        
        public Article Article
        {
            get
            {
                return _article;
            }
            set
            {
                this._article = value;
                OnPropertyChanged("Article");
                OnPropertyChanged("FullIllustrationAddress");
                OnPropertyChanged("ContentWebViewSource");
            }
        }


        public String FullIllustrationAddress
        {
            get { 
                if (this.Article != null)
                {
                    return $"https://api.blog.juleslaurent.fr/{this._article.IllustrationAddress}";
                }
                return String.Empty;
            }
        }

        public HtmlWebViewSource ContentWebViewSource
        {
            get
            {
                HtmlWebViewSource source = new HtmlWebViewSource();
                if (this.Article != null)
                {
                    source.Html = $"<html><body>{this.Article.Content}</body></html>";
                }
                return source;
            }
        }
        
        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is Article)
            {
                this.Article = (navigationData as Article);
            }
            return base.InitializeAsync(navigationData);
        }
    }
}