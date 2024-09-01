using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class FingerPay : IOdemeTipi
    {
        public string ode(double tutar)
        {
            return "Parmak izi ile " + tutar + " tl ödeme alınmıştır";
        }
    }
}
