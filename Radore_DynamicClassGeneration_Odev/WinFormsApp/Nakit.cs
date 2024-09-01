using System;
namespace WinFormsApp
{
    public class Nakit : IOdemeTipi
    {
        public string ode(double tutar)
        {
            return "Nakit ile " + tutar + " tl ödeme alınmıştır";
        }
    }
}
