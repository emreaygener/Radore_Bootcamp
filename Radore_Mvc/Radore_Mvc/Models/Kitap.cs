namespace Radore_Mvc.Models
{
    public class Kitap : IDisposable
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public double Fiyat { get; set; }
        public int SayfaSayisi { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
