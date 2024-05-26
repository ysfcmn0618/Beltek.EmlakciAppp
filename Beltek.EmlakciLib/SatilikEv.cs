using System;
using System.Collections.Generic;
using System.Text;

namespace Beltek.EmlakciLib
{
    public class SatilikEv:House
    {
        public double SatisFiyat { get; set; }

        public new string HouseInformation()
        {
            return $"{base.HouseInformation()}\n Satış Fiyatı : {SatisFiyat}";
        }
    }
}
