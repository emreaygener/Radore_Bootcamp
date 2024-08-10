using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class OdemeIslemi
    {
        public IOdemeTipi ödemeTipi;

        public OdemeIslemi(IOdemeTipi ödemeTipi)
        {
            this.ödemeTipi = ödemeTipi;
        }

        public string OdemeYap(double tutar)
        {
            return ödemeTipi.ode(tutar);
        }
    }
}
