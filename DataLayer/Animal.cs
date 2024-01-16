using System;

namespace DataLayer
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime BirthDay { get; set; }
        public int Weight { get; set; }

        public virtual void Solunum()
        {
            Console.WriteLine("Bütün Hayvanlar Solunum yapar");
        }
        public abstract bool IsYüzebilirmi();

    }
}
