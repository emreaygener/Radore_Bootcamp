using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Classes
{
    public class Matematik
    {
        public int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
        public int topla( params int[] sayilar)
        { 
            return sayilar.Sum();
        }
        public int cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }
    }
}
