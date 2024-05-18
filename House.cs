using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beltek.EmlakciApp
{
    internal class House
    {
        public int roomCount;
        public string? district;
        public int area;
        public int floorNo;


        //static : Bir üyenin class a ait olması isteniyorsa static tanımlanır nesneye ait olması isteniyorsa static tanımlanmaz
        //statick olursa erişim referansı class üzerinden olur .
        public string HouseInformation()
        {
            return $"Kat no : {this.floorNo}\nM2 : {this.area}\nSemt : {this.district}\nOda Sayısı : {this.roomCount}";
        }

    }
}
