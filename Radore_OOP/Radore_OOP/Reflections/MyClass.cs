using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Reflections
{
    public class MyClass
    {
        public int x;
        public int y;

        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MesajGoster()
        {
            Console.WriteLine("x in değeri " + x + " y nin değeri " + y);
        }

        public string MesajDön()
        {
            return " bir mesaj";
        }

        public bool IsBetween (int i)
        {
            if (i >0)
                return true;
            else
                return false;
        }
    }
}
