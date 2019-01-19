using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;
using TpXamarin.Models;

namespace TpXamarin.JLTApi
{
    interface IJLTApi
    {
        [Get("/articles")]
        Task<List<Article>> GetArticles();
    }
}
