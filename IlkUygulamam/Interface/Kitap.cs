using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkUygulamam.Interface
{
    internal class Kitap : IKitap
    {
        protected Ucret KitapUcret { get; set; }
        public string Name { get; set; }
        public string Writer { get; set; }
        public Kitap(Ucret ucret)
        {
            KitapUcret = ucret;
        }
        public Kitap()
        {
            // KitapUcret = ucret;
        }
        public bool IfOkundumu()
        {
            Console.WriteLine("Kitap okuyabildim.");
            return true;
        }

        public void Oku()
        {
            Console.WriteLine("Kitap okuyorum.");
            Console.WriteLine();
        }
        public void Hesapla()
        {
            int sonuc = KitapUcret.Price * KitapUcret.Kdv / 100;

            string message = String.Format("Kitabın ücreti : {0} {1}dir.", sonuc, "TL");

            Console.WriteLine(message);
        }
    }
}
