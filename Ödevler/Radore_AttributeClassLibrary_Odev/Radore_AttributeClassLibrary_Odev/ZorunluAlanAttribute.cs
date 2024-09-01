using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_AttributeClassLibrary_Odev
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public class ZorunluAlanAttribute : Attribute
    {

    }
}
