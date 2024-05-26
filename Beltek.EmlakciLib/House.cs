using System;

namespace Beltek.EmlakciLib
{
    public abstract class House
    {
        
        protected House()
        {
            Console.WriteLine("house constructor çalıştı ");
            sayac++;
        }
        protected House(int odaSayisi, int katNo, int alan, string semt)
        {
            this.OdaSayisi = odaSayisi;
            this.KatNo = katNo;
            this.Alan = alan;
            this.Semt = semt;
            sayac++;
        }

        private int odaSayisi;
        private string buyukluk;
        private string semt;
        private int alan;
        private int katNo;
        static int sayac;//Heap de Kaç adet House class ımızın olduğunu takip etmek için oluşturduğumuz field deneme

        public int Alan
        {
            get { return alan; }
            set
            {

                alan = value;
                if (alan < 120)
                {
                    this.buyukluk = "Küçük Ev";
                }
                else if (alan > 120 && alan < 150)
                {
                    this.buyukluk = "Orta Büyüklik";
                }
                else
                {
                    this.buyukluk = "Büyük Ev";
                }


            }
        }


        public int OdaSayisi { get => odaSayisi; set => odaSayisi = Math.Abs(value); }
        public string Buyukluk { get => buyukluk; }
        public string Semt { get => semt; set => semt = value.ToUpper(); }
        public int KatNo { get => katNo; set => katNo = value; }
        public static int Sayac { get => sayac; }

        public string HouseInformation()
        {
            return $"\nOda sayısı : {this.OdaSayisi} \nKat No:{this.KatNo} \nBüyüklük : {this.Buyukluk} \nAlan: {this.Alan} \nSemt:{this.Semt}";
        }
        //public static int CtorSayac()
        //{            
        //    return sayac;
        //}
        ~House()//Destructure method tilda ile oluşturulur işi bittiğinde heapden verileri silmeye yarar.
        {
            sayac--;//Heapden Bir nesnemiz eksildiğinde sayacımız bir azalacak.
        }


    }
}
//Garbage Collector(GC)