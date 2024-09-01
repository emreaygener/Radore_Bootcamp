using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Radore_Serialization
{
    [Serializable]
    public class Employee
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        [NonSerialized]
        [XmlIgnore]
        public string AdditionalInfo;

    }
}
