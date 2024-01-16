using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Yılan : Animal, IYuzmek, ISurunmek
    {
        List<Yılan> Defaultyılans;
        public Yılan()
        {
          
        }
        public List<Yılan> GetDefaultList()
        {
            Defaultyılans = new List<Yılan>();
            Defaultyılans.Add(new Yılan() { Name = "Kobra", Type = "Çıngıraklı", Weight = 40, BirthDay = Convert.ToDateTime("01.02.2000") });
            Defaultyılans.Add(new Yılan() { Name = "Mie", Type = "Su", Weight = 45, BirthDay = Convert.ToDateTime("10.10.1998") });
            Defaultyılans.Add(new Yılan() { Name = "Joe", Type = "Çıngıraklı", Weight = 25, BirthDay = Convert.ToDateTime("15.01.1996") });
            Defaultyılans.Add(new Yılan() { Name = "Debi", Type = "Boz", Weight = 10, BirthDay = Convert.ToDateTime("22.05.2005") });
            Defaultyılans.Add(new Yılan() { Name = "Koaa", Type = "Boz", Weight = 80, BirthDay = Convert.ToDateTime("25.04.2010") });
            Defaultyılans.Add(new Yılan() { Name = "Seoo", Type = "Su", Weight = 80, BirthDay = Convert.ToDateTime("25.04.2010") });
            return Defaultyılans;
        }
        public override bool IsYüzebilirmi()
        {
            Console.WriteLine("Yılanlar yüzebilir");
            return true;
        }

        public void Surunmek()
        {
            Console.WriteLine("Yılanlar sürünerek ilerler");
        }

        public void Yuzmek()
        {
            Console.WriteLine("Yılanlar yüzebilir");
        }
    }
}
