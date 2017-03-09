using System.Collections.Generic;
using Bukurov.Site.Data;
using Bukurov.Site.Data.Blogs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bukurov.Site.WebApp.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        private readonly InMemoryDataSource dataSource;

        public BlogController(InMemoryDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        [HttpGet("[action]")]
        [AllowAnonymous]
        public IEnumerable<Article> GetArticles()
        {
            var articles = dataSource.Articles;
            return articles;
        }
    }
}