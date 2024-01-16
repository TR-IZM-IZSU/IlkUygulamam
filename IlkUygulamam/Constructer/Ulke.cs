using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkUygulamam.Constructer
{
    public class Ulke
    {
        public string Name { get; set; }
        public string Dili { get; set; }
        public int YuzOlcumu { get; set; }
        private int log;
        public Ulke()
        {
            Console.WriteLine("Ulke Sınıfındna türeyen nesnem oluştu.");
        }
        public Ulke(string name)
        {
            Name = name;
        }
        public Ulke(int _log)
        {
            this.log = _log;
        }
        ~Ulke()
        {
            Console.WriteLine("Yıkıcı metot çalıştı.Nesne bitti");
        }

    }
}
