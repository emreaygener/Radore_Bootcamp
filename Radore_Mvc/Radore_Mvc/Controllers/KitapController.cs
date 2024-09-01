using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Radore_Mvc.Models;
using System.Net;
using System.Text;

namespace Radore_Mvc.Controllers
{
    public class KitapController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Kitap> kitaplar = new List<Kitap>();
            using (var client = new HttpClient())
            {
                using( var gelenYanit = await client.GetAsync("https://localhost:7262/api/kitap"))
                {
                    string gelenString = await gelenYanit.Content.ReadAsStringAsync();
                    kitaplar = JsonConvert.DeserializeObject<List<Kitap>>(gelenString);
                }
            }
            return View(kitaplar);
        }

        public async Task<IActionResult> Details(int id)
        {
            Kitap kitap = new Kitap();
            using (var client = new HttpClient())
            {
                using (var gelenYanit = await client.GetAsync("https://localhost:7262/api/kitap/" + id))
                {
                    string gelenString = await gelenYanit.Content.ReadAsStringAsync();
                    kitap = JsonConvert.DeserializeObject<Kitap>(gelenString);
                }
            }
            return View(kitap);
        }

        public ViewResult KitapOlustur() => View();
        [HttpPost]
        public async Task<IActionResult> KitapOlustur(Kitap kitap)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    StringContent seralizeEdilecekFilm = new StringContent(JsonConvert.SerializeObject(kitap), Encoding.UTF8, "application/json");
                    using (var gelenYanit = await client.PostAsync("https://localhost:7262/api/kitap", seralizeEdilecekFilm))
                    {
                        if (gelenYanit.StatusCode == HttpStatusCode.OK)
                        {
                            //İşlem başarılı mesajını gönder
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            return RedirectToAction("Index");
        }

        public ViewResult Edit(int id)
        {
            Kitap kitap = new Kitap();
            using (var client = new HttpClient())
            {
                using (var gelenYanit = client.GetAsync("https://localhost:7262/api/kitap/" + id).Result)
                {
                    string gelenString = gelenYanit.Content.ReadAsStringAsync().Result;
                    kitap = JsonConvert.DeserializeObject<Kitap>(gelenString);
                }
            }
            return View(kitap);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Kitap kitap, int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    StringContent serializedKitap = new StringContent(JsonConvert.SerializeObject(kitap), Encoding.UTF8, "application/json");
                    using (var response = await client.PutAsync("https://localhost:7262/api/kitap/" + id, serializedKitap))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            // İşlem başarılı mesajını gönder
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return RedirectToAction("Index");
        }

        public ViewResult DeleteView(int id)
        {
            Kitap kitap = new Kitap();
            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync("https://localhost:7262/api/kitap/" + id).Result)
                {
                    string gelenString = response.Content.ReadAsStringAsync().Result;
                    kitap = JsonConvert.DeserializeObject<Kitap>(gelenString);
                }
            }
            return View(kitap);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = await client.DeleteAsync("https://localhost:7262/api/kitap/" + id))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            // İşlem başarılı mesajını gönder
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return RedirectToAction("Index");
        }
    }
}
