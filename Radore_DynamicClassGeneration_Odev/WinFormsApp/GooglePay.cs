

namespace WinFormsApp
{
    public class GooglePay : IOdemeTipi
    {
        public string ode(double tutar)
        {
            return "Google Pay ile " + tutar + " tl ödeme alınmıştır";
        }
    }
}
