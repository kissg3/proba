using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek
{
    public class Konyv
    {
        public string Cim;
        public string Szerzo { get; set; }
        public int KiadasiEv { get; set; }
        public int Oldalszam { get; set; }
        public int Ar { get; set; }

        public Konyv(string cim, string szerzo, int kiadasiEv, int oldalszam, int ar)
        {
            Cim = cim;
            Szerzo = szerzo;
            KiadasiEv = kiadasiEv;
            Oldalszam = oldalszam;
            Ar = ar;
        }

        public override string ToString()
        {
            return $"{Cim};{Szerzo};{KiadasiEv};{Oldalszam};{Ar} Ft";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Konyv> konyveklista = new List<Konyv>();
            StreamReader sr = new StreamReader("konyvek.txt");
           
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] darabok = sor.Split(';');

                string cim = darabok[0];
                string szerzo = darabok[1];
                int kiadasiev =Convert.ToInt32( darabok[2]);
                int oldalszam = Convert.ToInt32(darabok[3]);
                int ar = Convert.ToInt32( darabok[4]);
                konyveklista.Add(new Konyv(cim, szerzo, kiadasiev, oldalszam, ar));


            }
            sr.Close();
            Console.WriteLine(" ennyi könyv találhato"+konyveklista.Count);
            int cel = 200-konyveklista.Count;
            if (cel>0)
            {
                Console.WriteLine("ennyi könyv hiányzik a 200-as célhoz"+ cel);
            }
            else
            {
                Console.WriteLine("ennyi könyvel van több mint a cél"+cel);
            }
            int db = 0;
            foreach (var konyv in konyveklista)
            {
                if (konyv.Ar>5000)
                {
                    db++;
                }
            }
            Console.WriteLine("ennyi könyv van 5000 felet:"+db);
             bool vane = false;
           
                foreach (var konyv in konyveklista)
                {
                    if (konyv.Ar >= 20000)
                    {
                        vane = true;
                        Console.WriteLine("van ilyen könyv");
                        break;
                       
                    }
                   
                }
            if (vane==false)
            {
                Console.WriteLine("nincs ilyen könyv");
            }
            int legolcsobb = 0;
            string legolcsobbcime = "";
            string legolcsobbszerzo = "";
            int legolcsobbkiadasiev = 0;
            int legolcsobboldalszam = 0;
           
            foreach (var konyv in konyveklista)
            {
                legolcsobb = konyv.Ar;
            }
            foreach (var konyv in konyveklista)
            {
                if (konyv.Oldalszam>300)
                {
                    if (konyv.Ar<legolcsobb)
                    {
                        legolcsobb=konyv.Ar;
                        legolcsobbcime = konyv.Cim;
                        legolcsobbszerzo = konyv.Szerzo;
                        legolcsobbkiadasiev = konyv.KiadasiEv;
                        legolcsobboldalszam = konyv.Oldalszam;
                    }
                }
            }
          
            Console.WriteLine("A legolcsobb 300 oldalas konyv ára:"+legolcsobb+"A konyv cime:"+legolcsobbcime+"a könyv szerzője:"+" "+legolcsobbszerzo+" "+" kiadási éve:"+legolcsobbkiadasiev+" "+" a konyv oldal száma:"+legolcsobboldalszam);
            int konyvdb1 = 0;//0-1000
            int konyvdb2 = 0;//1001-2000
            int konyvdb3 = 0;//2001-3000
            int konyvdb4 = 0;//3001-4000
            int konyvdb5 = 0;//4001-5000
            int konyvdb6 = 0;//5001-6000
            int konyvdb7 = 0;//6001-7000
            int konyvdb8 = 0;//7001-8000
            int konyvdb9 = 0;//8001-9000
            int konyvdb10 = 0;//9001-10000
            int konyvdb11 = 0;//10000 fellet
            foreach (var konyv in konyveklista)
            {
                if (konyv.Ar<=1000)
                {
                    konyvdb1++;
                }
                else if (konyv.Ar<=2001&&konyv.Ar>=1001)
                {
                    konyvdb2++;
                }
                else if (konyv.Ar <= 3001 && konyv.Ar >= 2001)
                {
                    konyvdb3++;
                }
                else if (konyv.Ar <= 4001 && konyv.Ar >= 3001)
                {
                    konyvdb4++;
                }
                else if (konyv.Ar <= 5001 && konyv.Ar >= 4001)
                {
                    konyvdb5++;
                }
                else if (konyv.Ar <= 6001 && konyv.Ar >= 5001)
                {
                    konyvdb6++;
                }
                else if (konyv.Ar <= 7001 && konyv.Ar >= 6001)
                {
                    konyvdb7++;
                }
                else if (konyv.Ar <= 8001 && konyv.Ar >= 7001)
                {
                    konyvdb8++;
                }
                else if (konyv.Ar <= 9001 && konyv.Ar >= 8001)
                {
                    konyvdb9++;
                }
                else if (konyv.Ar <= 10001 && konyv.Ar >= 9001)
                {
                    konyvdb10++;
                }
                else if (konyv.Ar > 10001 )
                {
                    konyvdb11++;
                }

            }
            Console.WriteLine(" 0-1000Ft konyv db:"+konyvdb1);
            Console.WriteLine(" 1001-2001Ft konyv db:" + konyvdb2);
            Console.WriteLine(" 2001-3000Ft konyv db:" + konyvdb3);
            Console.WriteLine(" 3001-4000Ft konyv db:" + konyvdb4);
            Console.WriteLine(" 4001-5000Ft konyv db:" + konyvdb5);
            Console.WriteLine(" 5001-6000Ft konyv db:" + konyvdb6);
            Console.WriteLine(" 6001-7000Ft konyv db:" + konyvdb7);
            Console.WriteLine(" 7001-8000Ft konyv db:" + konyvdb8);
            Console.WriteLine(" 80001-9000Ft konyv db:" + konyvdb9);
            Console.WriteLine(" 9001-10000Ft konyv db:" + konyvdb10);
            Console.WriteLine(" 10000 Ft fellet konyv db:" + konyvdb11);


            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
