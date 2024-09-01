using System;
namespace WinFormsApp
{
    public class Paypal : IOdemeTipi
    {
        public string ode(double tutar)
        {
            return "PayPal ile " + tutar + " tl ödeme alınmıştır";
        }
    }
}
