using DataLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class AnimalFactory
    {

        Yılan yılan = new Yılan();
        private object serializer;

        public void Execute()
        {

            XElement contacts = XElement.Load(@"c:\myContactList.xml");
            foreach (XElement contact in contacts.Elements())
            {
                Console.WriteLine(contact.Name);
            }
            contacts.Add(new object());

            //Northwnd db = new Northwnd(@"c:\northwnd.mdf");


            List<Yılan> yılans = yılan.GetDefaultList();

            yılans = yılans.Where(x => x.Weight > 20 && x.Name.StartsWith("K") || (x.Type == "Boz")).ToList();

            var kisaltilmis = yılans.OrderByDescending(x => x.Name).ToList();

            var kisaltilmis2 = (from p in yılans
                                orderby p.Name.ToLower() descending
                                select p).ToList();



            string json = JsonConvert.SerializeObject(kisaltilmis2);


            var sorguyılans = from p in yılans
                              where p.Weight > 20 && p.Name.StartsWith("K") || p.Type == "Boz"
                              select p;

            foreach (var yılan in yılans)
            {
                string aciklama = String.Format("Yılanın ismi {0} ağırlıgı {1} kg {2} türündendir.", yılan.Name, yılan.Weight, yılan.Type);

                Console.WriteLine(aciklama);
            }

        }


    }
}
