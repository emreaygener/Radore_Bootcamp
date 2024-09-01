using Article.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Article.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleRepository _articleRepository;

        public ArticlesController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        [HttpGet]
        public IActionResult GetAllArticles()
        {
            return Ok(_articleRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetArticleDetail(int id)
        {
            var article = _articleRepository.GetById(id);
            if (article == null)
            {
                return NotFound();
            }
            return Ok(article);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteArticle(int id)
        {
            var deletedId = _articleRepository.Delete(id);
            return Ok(deletedId);
        }
    }
}
