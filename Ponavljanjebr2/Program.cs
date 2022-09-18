using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanjebr2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool num1;
            Console.WriteLine("Padaju li stablu listovi?");
            Console.WriteLine("Napisi 1 ako listovi padaju ili napisi 0 ako listovi ne padaju");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                num1 = true;
                Stablo stablo1 = new Stablo(num1, " ");
                Console.WriteLine(stablo1.ToString());
            }
            if (num == 0)
            {
                num1 = false;
                Stablo stablo1 = new Stablo(num1, " ");
                Console.WriteLine(stablo1.ToString());
            }
            Console.ReadKey();
        }
    }
    class Stablo
    {
        bool otpadajuListovi;
        string vrstaStabla;


        public override string ToString()
        {
            string ispis;
            if (this.otpadajuListovi == false)
            {
                this.vrstaStabla = "crnogorično";
                ispis = "Listovi ne padaju pa znaci da je stablo " + this.vrstaStabla;
                return ispis;
            }
            if (this.otpadajuListovi == true)
            {
                this.vrstaStabla = "bijelogorično";
                ispis = "Listovi padaju pa znaci da je stablo " + this.vrstaStabla;
                return ispis;
            }
            else
            {
                return this.vrstaStabla;
            }


        }
        public Stablo()
        {

        }

        public Stablo(bool otpadajuListovi, string vrstaStabla)
        {
            this.otpadajuListovi = otpadajuListovi;
            this.vrstaStabla = vrstaStabla;
        }

        public void setotpadajuListovi(bool otpadajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
        }
        public void setvrstaStabla(string vrstaStabla)
        {
            this.vrstaStabla = vrstaStabla;
        }

        public bool getotpadajuListovi()
        {
            return this.otpadajuListovi;
        }
        public string getvrstaStabla()
        {
            return this.vrstaStabla;
        }
    }
}

