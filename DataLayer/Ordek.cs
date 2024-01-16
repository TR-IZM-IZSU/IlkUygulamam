using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Ordek : Animal, IYuzmek, IUcabilir, IKosmak
    {
        public List<Ordek> DefaultOrdekList;

        public List<Ordek> GetDefaultList()
        {
            DefaultOrdekList = new List<Ordek>();

            return DefaultOrdekList;
        }
        public override bool IsYüzebilirmi()
        {
            Console.WriteLine("Ördekler yüzebilir");
            return true;
        }

        public void Kosmak()
        {
            Console.WriteLine("Ördekler koşabilir");
        }

        public void Ucmak()
        {
            Console.WriteLine("Ördekler uçabilir");
        }

        public void Yuzmek()
        {
            Console.WriteLine("Ördekler yüzebilir");
        }
    }
}
