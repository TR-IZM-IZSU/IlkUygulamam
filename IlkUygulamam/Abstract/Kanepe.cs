using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkUygulamam.Abstract
{
    internal class Kanepe : Mobilya
    {
        public string Kumas { get; set; }
        public override void ozellikyaz()
        {
            Console.WriteLine("Kanepenin özellikleri");
            Console.WriteLine("Renk:" + Renk);
            Console.WriteLine("Kumaş:" + Kumas);
        }
        public override void Hesapla()
        {
            base.Hesapla();
            Console.WriteLine("Kanepe hesaplandı");
        }
    }
}
