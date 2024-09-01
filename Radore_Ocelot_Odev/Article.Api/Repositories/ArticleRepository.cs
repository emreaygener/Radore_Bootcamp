using Article.Api.Data;
using Article.Api.Repositories.Interfaces;

namespace Article.Api.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ApplicationDbContext context;

        public ArticleRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public int Delete(int id)
        {
            var article = context.Articles.FirstOrDefault(a => a.Id == id);
            if (article != null)
            {
                context.Articles.Remove(article);
                context.SaveChanges();
            }
            return article?.Id ?? id;
        }

        public List<Models.Article> GetAll() => context.Articles.ToList();

        public Models.Article GetById(int id) => context.Articles.FirstOrDefault(a => a.Id == id);
    }
}
