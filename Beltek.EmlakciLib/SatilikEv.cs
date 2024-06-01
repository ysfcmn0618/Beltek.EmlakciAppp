using System;
using System.Collections.Generic;
using System.Text;

namespace Beltek.EmlakciLib
{
    public class SatilikEv : House
    {
        public SatilikEv()
        {

        }
        public SatilikEv(int odaSayisi, int katNo, int alan, string semt, double satisFiyatı) : base(odaSayisi, katNo, alan, semt)
        {
            SatisFiyat = satisFiyatı;
        }
        public double SatisFiyat { get; set; }

        //public new string HouseInformation()
        //{
        //    return $"{base.HouseInformation()}\n Satış Fiyatı : {SatisFiyat}";
        //}
        public override string HouseInformation()
        {
            return $"{base.HouseInformation()}\n Satış Fiyatı : {SatisFiyat}";
        }
    }
}
