using System;
using System.Collections.Generic;
using System.Text;

namespace EromuApp
{
    public class eromu
    {
        public string Azonosito { get; set; }
        protected int kapacitasKW { get; set; }

        public int KapacitasKW { 
            get;


            set
            {
                if (KapacitasKW>=0)
                {
                    KapacitasKW = 100;
                }


            }
                }
         private static int osszesEromuSzama { get; set; }
         public static int OsszesEromuSzama { get; }


        public void eromuvek(string azonosito,int kapacitasKW)
        {
            Azonosito = azonosito;
            KapacitasKW = kapacitasKW;

        }
        public virtual int NapiTermeles(int orakSzama)
        {
            return
            KapacitasKW * orakSzama;
    
        }
        public override string ToString()
        {
            Console.WriteLine($"Erőmű {Azonosito} | Kapacitás: {KapacitasKW} KW");
        }
    }
}
