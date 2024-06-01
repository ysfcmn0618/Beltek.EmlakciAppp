using System;
using System.Collections.Generic;
using System.Text;

namespace Beltek.EmlakciLib
{
    public class KiralikEv : House

    {
        public KiralikEv()
        {

        }
        public KiralikEv(int odaSayisi, int katNo, int alan, string semt, double kira, double depozito) : base(odaSayisi, katNo, alan, semt)
        {
            //base.OdaSayisi = odaSayisi;
            //base.KatNo = katNo;
            //base.Alan = alan;   
            //base.Semt = semt;
            Kira = kira;
            Depozito = depozito;
        }
        public double Kira { get; set; }
        public double Depozito { get; set; }

        //public new string HouseInformation()
        //{
        //    return $"{base.HouseInformation()}\n Kira : {Kira} \nDepozito : {Depozito}";
        //}
        public override string HouseInformation()
        {
            return $"{base.HouseInformation()}\n Kira : {Kira} \nDepozito : {Depozito}";
        }
    }
}
