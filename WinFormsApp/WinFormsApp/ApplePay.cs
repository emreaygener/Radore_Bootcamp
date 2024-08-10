namespace WinFormsApp
{
    public class ApplePay : IOdemeTipi
    {
        public string ode(double tutar)
        {
            return "Apple Pay ile " + tutar + " tl ödeme alınmıştır";
        }
    }
}