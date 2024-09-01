using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_Serialization
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public DateTime ExpireDate { get; set; }
        public double Price { get; set; }
    }
}
