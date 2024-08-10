using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
