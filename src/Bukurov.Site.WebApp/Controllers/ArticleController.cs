using System.Collections.Generic;
using Bukurov.Site.Data;
using Bukurov.Site.Data.Blogs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Bukurov.Site.WebApp.Controllers
{
    [Route("api/articles")]
    public class ArticleController : Controller
    {
        private readonly InMemoryDataSource dataSource;

        public ArticleController(InMemoryDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<Article> GetArticles()
        {
            var articles = dataSource.Articles;
            return articles;
        }

        [HttpGet]
        [AllowAnonymous]
        public Article GetArticle(Guid id)
        {
            var article = dataSource.Articles.First(a => a.Id == id);
            return article;
        }
    }
}