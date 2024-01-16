using BusinessLayer;
using IlkUygulamam.Abstract;
using IlkUygulamam.Constructer;
using IlkUygulamam.Interface;
using IlkUygulamam.Kalıtım;
using IlkUygulamam.Renkler;
using System;
using System.Collections;
using System.Collections.Generic;

namespace IlkUygulamam
{
    internal class Program
    {
        public static string message = "Kırmızı Renkli Butona tıkaldınız.";
        static void Main(string[] args)
        {
            #region 1.ders
            //Calculator calculator = new Calculator();
            //int yaslartoplami = calculator.Topla(23, 34);
            //int yaslartoplami2 = calculator.Topla(23, 34, 12);
            //int yaslartoplamI = calculator.Topla(23, 34, 5, 67);

            //int[] sayilar = { 2, 3, 5, 6, 7, 23, 45, 64 };

            //string sayilartoplami = calculator.Topla(sayilar);

            //string x = calculator.Topla(23, 34).ToString();

            //String xV = calculator.Topla(23, 34).ToString();


            //string soyisim = GetSurName("secil");


            //Console.WriteLine("Hello World!");
            //Console.WriteLine(message);
            //Console.WriteLine(soyisim);
            //Console.WriteLine(yaslartoplami);
            //Console.WriteLine(sayilartoplami);
            #endregion

            #region 2. ders

            //Ulke türkiye = new Ulke();
            //türkiye.Dili = "Türkçe";
            //türkiye.Name = "Türkiye Cumhuriyeti";
            //türkiye.YuzOlcumu = 121414;
            //Console.WriteLine(türkiye.Name);


            ////Kus kus = new Kus();
            ////kus.Bosaltım();
            ////kus.Kosma();
            ////kus.Hareket();
            ////kus.SarkiSoyle();
            ////kus.Bosaltım();

            //Canlılar balik = new Balik();
            //balik.Hareket();

            #endregion

            #region 3. ders

            //  Mobilya mobilya = new Mobilya();

            //Kanepe kanepe = new Kanepe();
            //Masa masa = new Masa();

            //kanepe.Renk = "Pembe";
            //kanepe.Kumas = "Deri";

            //masa.Renk = "Yeşil";
            //masa.Malzeme = "Cam";


            //kanepe.ozellikyaz();
            //kanepe.Hesapla();
            //kanepe.GetRenk();

            //masa.ozellikyaz();
            //masa.Hesapla();
            //masa.GetRenk();



            //var sayilarim = new string[5] { "aasd", "şl", "kl", "gh", "df" };

            //var isim = "secil";

            //var yas = 23;

            //   List<int> intList = new List<int>();
            //intList.Add(23);
            //intList.Add((int)yas);
            //intList.Add(4);

            //var sayilar = new ArrayList() {
            //                                1, "2", "üç", true, 'b'
            //                                };


            //Ucret ucret = new Ucret();
            //ucret.Price = 123;
            //ucret.Kdv = 18;
            //ucret.Description = "Kitabın birim ücreti";
            //ucret.Discount = 10;
            //Kitap kitap = new Kitap(ucret);
            //kitap.Hesapla();

            //Collections collections = new Collections();
            //collections.ListDefinations();

            //Kirmizi kirmizi = new Kirmizi();
            #endregion


            AnimalFactory factory = new AnimalFactory();

            factory.Execute();

            Console.ReadLine();
        }

        private static string GetSurName(string name)
        {
            if (name == "secil")
            {
                return "coban";
            }
            else if (name == "melda")
            {
                return "kaya";
            }
            else
            {
                return "yok";
            }
        }
    }
}
