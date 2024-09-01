using System;
namespace WinFormsApp
{
    public class IrisPay : IOdemeTipi
    {
        public string ode(double tutar)
        {
            return "Iris Pay ile " + tutar + " tl ödeme alınmıştır";
        }
    }
}
