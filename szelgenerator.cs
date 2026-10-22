using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;


namespace EromuApp
{
    public class szelgenerator:eromu
    {
        public int toronymagassag { get; set; }

        public void ezek(string azonosito,int Toronymagassag, int kapacitasKW):base(Azonosito, KapacitasKW )
        {
            toronymagassag = toronymagassag;
        }
        public override int NapiTermeles(int orakSzama)
        {
            return
            base.NapiTermeles(orakSzama+toronymagassag*10*orakSzama);
        }
        public override string ToString()
        {
            return 
            base.ToString(Console.WriteLine($"Toronymagasság:{toronymagassag}m"));
        }
    }
}
