using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkUygulamam.Abstract
{
    internal class Masa : Mobilya
    {
        public string Malzeme { get; set; }
        public override void ozellikyaz()
        {
            Console.WriteLine("Masanın Özellikleri");
            Console.WriteLine("Renk:" + Renk);
            Console.WriteLine("Malzeme" + Malzeme);
        }
    }
}
