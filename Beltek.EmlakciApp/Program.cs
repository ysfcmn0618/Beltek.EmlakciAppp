using Beltek.EmlakciLib;

namespace Beltek.EmlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var myHouse = new House();
            //myHouse.floorNo = 1;
            //myHouse.roomCount = 3;
            //myHouse.area = 125;
            //myHouse.district = "Ali Ersoy";

            //Console.WriteLine(myHouse.HouseInformation());

            //var house2 = new House { area = 120, district = "Yenimahalle", roomCount = 4, floorNo = 7 };

            //Console.WriteLine(house2.HouseInformation());

            //var house = new House();
            //var evim = new House();
            //Console.WriteLine(House.Sayac);

            //Console.Write("Evin Semtini giriniz :");
            //house.Semt=Console.ReadLine();
            //Console.Write("Kat numarasını giriniz :");
            //house.KatNo=int.Parse(Console.ReadLine());
            //Console.Write("Oda sayısını giriniz :");
            //house.OdaSayisi= int.Parse(Console.ReadLine());


            //Console.WriteLine($"Girdiğiniz ev bilgileri : {house.HouseInformation()}");

            KiralikEv ke = new();
            ke.Kira = 500;
            ke.Alan = 130;
            ke.OdaSayisi = 4;
            ke.Depozito = 200;
            ke.Semt = "Kiralık";
            ke.KatNo = 3;
            //Console.WriteLine(ke.HouseInformation());

            var ke1 = new KiralikEv(3, 10, 225, "Kiralık", 25650, 80000);
            var se = new SatilikEv(18, 3, 500, "Satılk", 25000000);
            var se1 = new SatilikEv(4, 8, 200, "Satılık ev", 10000);

            House[] evler = new House[4];
            evler[0] = se;
            evler[1] = se1;
            evler[2] = ke;
            evler[3] = ke1;

            for (int i = 0; i < evler.Length; i++)
            {
                //if (evler[i] is SatilikEv)
                //{

                //    SatilikEv sev=(SatilikEv)evler[i];
                //    Console.WriteLine(sev.HouseInformation());
                //}
                //else
                //{
                //    KiralikEv kev =(KiralikEv)evler[i];
                //    Console.WriteLine(kev.HouseInformation());
                //}
                Console.WriteLine(evler[i].HouseInformation());
                Console.WriteLine("-----------------------------------");
            }

        }



    }

}
//static : Bir üyenin class a ait olması isteniyorsa static tanımlanır nesneye ait olması isteniyorsa static tanımlanmaz
//statick olursa erişim referansı class üzerinden olur .
//static : Bir üyenin class a ait olması isteniyorsa static tanımlanır nesneye ait olması isteniyorsa static tanımlanmaz
//statick olursa erişim referansı class üzerinden olur .
// Polimorphizm çok biçimlilik base clasımız da yazılan bir methodu virtual (sanal ) pozisyona getirerek override (üstüne yazılabilir) pozisyonuna getirmiş oluyoruz.Daha sonra üst classımız da override methodu oluşturup aynı method ismin de üstüne yazılabilir bir fonksiyon geitiriyoruz.böylecede temel base clas tipinde bir nesneyi array tuttuğumuz zaman. üst clas tipinde bir referans oluşturmamıza gerek kalmadan base class üzerinden hazırlamış olduğumuz methoda erişerek üst clasın bilgilerine erişe biliyoruz .
