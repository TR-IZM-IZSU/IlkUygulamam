using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkUygulamam.Abstract
{
    abstract class Mobilya
    {
        public string Renk { get; set; }
        abstract public void ozellikyaz();

        public virtual void Hesapla()
        {
            Console.WriteLine("Mobilya ücreti hesaplandı");
        }
        public string GetRenk()
        {
            Console.WriteLine(Renk);
            return Renk;
        }
    }
}
