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
            ke.Semt = "Gazi";
            ke.KatNo = 3;
            Console.WriteLine(ke.HouseInformation());

         
        }


        
    }
        
}
//static : Bir üyenin class a ait olması isteniyorsa static tanımlanır nesneye ait olması isteniyorsa static tanımlanmaz
//statick olursa erişim referansı class üzerinden olur .
//static : Bir üyenin class a ait olması isteniyorsa static tanımlanır nesneye ait olması isteniyorsa static tanımlanmaz
//statick olursa erişim referansı class üzerinden olur .
