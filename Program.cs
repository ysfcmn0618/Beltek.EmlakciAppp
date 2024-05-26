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

            var house = new House();

            Console.Write("Evin Semtini giriniz :");
            house.Semt=Console.ReadLine();
            Console.Write("Kat numarasını giriniz :");
            house.KatNo=int.Parse(Console.ReadLine());
            Console.Write("Oda sayısını giriniz :");
            house.OdaSayisi= int.Parse(Console.ReadLine());
            //Console.Write("Evin net alanını giriniz : ");
            //house.Buyukluk(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Girdiğiniz ev bilgileri : {house.HouseInformation()}");

        }




    }
}
//static : Bir üyenin class a ait olması isteniyorsa static tanımlanır nesneye ait olması isteniyorsa static tanımlanmaz
//statick olursa erişim referansı class üzerinden olur .
//static : Bir üyenin class a ait olması isteniyorsa static tanımlanır nesneye ait olması isteniyorsa static tanımlanmaz
//statick olursa erişim referansı class üzerinden olur .