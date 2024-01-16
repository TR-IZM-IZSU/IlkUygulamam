using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Koyun : Animal, IKosmak, IYuzmek
    {
        public override bool IsYüzebilirmi()
        {
            Console.WriteLine("Koyun yüzebilir");
            return true;
        }

        public void Kosmak()
        {
            Console.WriteLine("Koyun koşabilir");
        }

        public void Yuzmek()
        {
            Console.WriteLine("Koyun yüzebilir");
        }
    }
}
