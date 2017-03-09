using System;
using System.Collections.Generic;
using Bukurov.Site.Data.Blogs;

namespace Bukurov.Site.Data
{
    public class InMemoryDataSource
    {
        public IList<Article> Articles { get; set; }

        public InMemoryDataSource()
        {
            this.Articles = new List<Article>();
            this.GenerateArticles();
        }

        private void GenerateArticles()
        {
            var article = new Article();
            article.Id = Guid.NewGuid();
            article.Title = "Article 1";
            article.Content = "Blah blah blah";
            this.Articles.Add(article);
        }
    }
}