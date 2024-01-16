using IlkUygulamam.Enums;
using IlkUygulamam.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkUygulamam
{
    public class Collections
    {

        List<Kitap> kitaps = new List<Kitap>();
        IEnumerable<Kitap> Kitaps = new List<Kitap>();
        ICollection<Kitap> kitapsColelction = new List<Kitap>();
        IList<Kitap> IKitaps = new List<Kitap>();

        Kitap kitap;

        public void ListDefinations()
        {
            try
            {



                kitap = new Kitap();
                kitap.Name = "Vadideki Zambak";
                kitap.Writer = "Balzac";

                kitaps.Add(kitap);



                Kitap kitap2 = new Kitap();
                kitap2.Name = "Yaban";
                kitap2.Writer = "Yakup Kadri Karaosmanoğlu";

                kitaps.Add(kitap2);



                foreach (var item in kitaps)
                {
                    Console.WriteLine("Kitabın adi:" + item.Name + "Kitabın yazarı:" + item.Writer);
                }

                kitaps.ForEach(item =>
                {
                    Console.WriteLine("Kitabın adi2:" + item.Name + "Kitabın yazarı2:" + item.Writer);

                });

                IKitaps.Add(kitap);
                kitapsColelction.Where(x => x.Writer == "Yakup").Select(x => x.Name).ToList();
                List<string> workTypeList = new List<string>();
                workTypeList.Add(WorkType.AKS.ToString());

                var durumint = Status.Closed.ToString();
                var durumstr = (Int32)Status.Closed;
                var durum = Status.Closed;
            }
            catch (Exception ex)
            {

                ///throw ex.
            }

        }



    }
}
