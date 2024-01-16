using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkUygulamam.Kalıtım
{
    public class Canlılar
    {
        public void Beslenme()
        {
            Console.WriteLine("Besleniyorum");
           // Canlıalrın beslenme methodudur bundna bıundna doalyı yazıldı seçil çoban
        }
        public virtual void Hareket()
        {
            Console.WriteLine("Hareker ediyorum");
        }
        public void Bosaltım()
        {
            Console.WriteLine("hihihi");
        }
    }
}
