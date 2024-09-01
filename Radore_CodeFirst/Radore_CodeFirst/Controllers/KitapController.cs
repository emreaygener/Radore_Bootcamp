using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Radore_CodeFirst.Data;
using Radore_CodeFirst.Models;

namespace Radore_CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitapController : ControllerBase
    {
        ApplicationDbContext _context;

        public KitapController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Kitap controllerı swagger postman yada tarayıcıdan çağırdığım zaman ilk olarak bu metot tetiklenecek.
        [HttpGet(Name ="GetBooks")]
        public async Task<ActionResult<IEnumerable<Kitap>>> Get()
        {
            List<Kitap> kitapListesi;
            // Select * From Kitap
            kitapListesi = await _context.Kitap.ToListAsync();
            return kitapListesi;
        }

        [HttpGet("{id}", Name = "GetBookById")]
        public async Task<ActionResult<Kitap>> GetById(int id)
        {
            var kitap = await _context.Kitap.FindAsync(id);

            if (kitap == null)
            {
                return NotFound();
            }

            return kitap;
        }

        [HttpPost(Name = "AddBook")]
        public async Task<ActionResult<Kitap>> Post([FromBody] Kitap kitap)
        {
            try
            {
                // Insert into Kitap (KitapAdi, Fiyat, SayfaSayisi) values (kitap.KitapAdi, kitap.Fiyat, kitap.SayfaSayisi)
                _context.Kitap.Add(kitap);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
            return Ok(kitap);
        }

        [HttpPut("{id}", Name ="UpdateBook")]
        public async Task<ActionResult<Kitap>> Put([FromBody] Kitap kitap, int id)
        {
            var entity = await _context.Kitap.FindAsync(id);
            if ( entity == null)
            {
                return NotFound();
            }

            kitap.Id = id;
            try
            {
                entity.SayfaSayisi = kitap.SayfaSayisi;
                entity.Fiyat = kitap.Fiyat;
                entity.KitapAdi = kitap.KitapAdi;

                _context.Update(entity);

                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw;
            }
            
                return Ok(kitap);
        }

        [HttpDelete("{id}", Name = "DeleteBook")]
        public async Task<ActionResult<Kitap>> Delete(int id)
        {
            var kitap = await _context.Kitap.FindAsync(id);
            if (kitap == null)
            {
                return NotFound();
            }
            try
            {
                _context.Kitap.Remove(kitap);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }

            return Ok(kitap);
        }


    }
}
