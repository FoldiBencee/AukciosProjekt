using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
namespace aukcioprojekt
{
    public class Festmeny
    {
        public Festmeny()
        { 
        private string stilus;
        private string cim;
        private string festo;
        int licitekSzama;
        int legmagasabbLicit;
        bool elkelt;
        DateTime LegutolsoLicitIdeje;
        DateTime most = DateTime.Now;



        public string Cim { get => cim; set => cim = value; }
        public string Festo { get => festo; set => festo = value; }
        public string Stilus { get => stilus; set => stilus = value; }
        public int LicitekSzama { get => licitekSzama; set => licitekSzama = value; }
        public int LegmagasabbLicit { get => legmagasabbLicit; set => legmagasabbLicit = value; }
        public bool Elkelt { get => elkelt; set => elkelt = value; }
        public DateTime LegutolsoLicitIdeje1 { get => LegutolsoLicitIdeje; set => LegutolsoLicitIdeje = value; }

        public override string ToString()
        {
            return festo + ": " + cim + "(" + stilus + "\n)"+ " meg ki ir sokmindent";
               
        }
        public void Licit()
        {
            if (elkelt)
            {
                Console.WriteLine("nem tortenik semmi!!!!HIBA mar elkelt");
            }
            else if (licitekSzama <1)
            {
                legmagasabbLicit += 100;
                licitekSzama++;
                LegutolsoLicitIdeje = most;
            }
            else
            {
                legmagasabbLicit += legmagasabbLicit / 10;
                licitekSzama++;
                LegutolsoLicitIdeje = most;

            }


        }
        public void Licit(int mertek)
        {
            if (mertek > 9 && mertek <101)
            {
                legmagasabbLicit += legmagasabbLicit / mertek;
                licitekSzama++;
                LegutolsoLicitIdeje = most;
            }
            else
            {
                Console.WriteLine("HIBAAAAAAAAAAAA");
            }



        }



    }
    }
}