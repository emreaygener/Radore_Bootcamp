using Microsoft.AspNetCore.Mvc;
using Writer.Api.Repositories.Interfaces;

namespace Writer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WritersController : ControllerBase
    {
        private readonly IWriterRepository _writerRepository;

        public WritersController(IWriterRepository writerRepository)
        {
            _writerRepository = writerRepository;
        }

        [HttpGet]
        public IActionResult GetAllWriters()
        {
            return Ok(_writerRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetWriterDetail(int id)
        {
            var writer = _writerRepository.Get(id);
            if (writer == null)
            {
                return NotFound();
            }
            return Ok(writer);
        }

        [HttpPost]
        public IActionResult SaveWriter(Models.Writer writer)
        {
            var createdWriter = _writerRepository.Insert(writer);
            return CreatedAtAction(nameof(GetWriterDetail), new { id = createdWriter.Id }, createdWriter);
            //return Created($"/get/{createdWriter.Id}", createdWriter);
        }
    }
}
