using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkUygulamam.Kalıtım
{
    public class Balik : Hayvanlar
    {
        public override void Hareket()
        {
            base.Hareket();
            Console.WriteLine("Ben balığım Yüzebilirim");
        }
    }
}
