using Article.Api.Repositories.Interfaces;

namespace Article.Api.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private static List<Models.Article> articles = populateArticles();
        private static List<Models.Article> populateArticles()
        {
            var articleList = new List<Models.Article>()
            {
                new Models.Article()
                {
                    Id = 1,
                    Title = "Article 1",
                    LastUpdate = DateTime.Now,
                    WriterId = 1
                },
                new Models.Article()
                {
                    Id = 2,
                    Title = "Article 2",
                    LastUpdate = DateTime.Now,
                    WriterId = 2
                },
                new Models.Article()
                {
                    Id = 3,
                    Title = "Article 3",
                    LastUpdate = DateTime.Now,
                    WriterId = 3
                }
            };
            return articleList;
        }
        public int Delete(int id)
        {
            var article = articles.FirstOrDefault(a => a.Id == id);
            if (article != null)
            {
                articles.Remove(article);
            }
            return article?.Id ?? id;
        }

        public List<Models.Article> GetAll() => articles;

        public Models.Article GetById(int id) => articles.FirstOrDefault(a => a.Id == id);
    }
}
