using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarsayilanDegerliParametreler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinifim s = new Sinifim();
            s.Selamla();
            s.Selamla("arda ");
        }
    }
    class Sinifim
    {
        public  void Selamla(string ad = "ali")
        {
            Console.WriteLine("merhaba " + ad);
        }
    }
}
