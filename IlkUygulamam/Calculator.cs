using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkUygulamam
{
    public class Calculator
    {
        // Ctrl K+D 
        private int gelenSayi;
        public int GelenSayi
        {
            get { return gelenSayi; }
            set
            {
                if (value <= 100 && value >= 0)
                {
                    gelenSayi = value;
                }
                else if (value < 0)
                {
                    gelenSayi = 0;
                    throw new Exception("Fazla soğuk");
                }
                else
                {
                    // Console.WriteLine("Aşırı ısınma engellendi"); // Bu şeklide sınıfımızı Windows formda 
                    //çalıştırmak istediğimizde çalışmaz.Bunun yerine
                    //aşağıdaki şekilde Hata fırlatabiliriz.

                    gelenSayi = 100;
                    throw new Exception("Aşırı derecede ısınma var");

                }
            }
        }
        public DateTime BirthDay { get; set; }
        public int Topla(int param1, int param2)
        {
            GelenSayi = 120;
            return param1 + param2;
        }
        public int Topla(int param1, int param2, int param3)
        {
            return param1 + param2 + param3;
        }
        public int Topla(int param1, int param2, int param3, int param4)
        {
            return param1 + param2 + param3 + param4;
        }

        public string Topla(int[] sayilar)
        {
            int döneceksonuc = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    döneceksonuc += sayilar[i];
            //}

            foreach (int i in sayilar)
            {
                döneceksonuc += i;
            }

            return "Toplanacak  Sayılar :" + döneceksonuc;
        }

        public bool IsExistC(string param)
        {
            if (param.Contains("c"))

                return true;

            else
                return false;
        }

    }
}
