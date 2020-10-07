using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2_Grupa2
{
     public class Hotel
    {
        private static string ime;
        private static string prezime;
        private static string smestaj;
        private static string obroci;

        public static string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public static string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public static string Smestaj
        {
            get { return smestaj; }
            set { smestaj = value; }
        }
        public static string Obroci
        {
            get { return obroci; }
            set { obroci = value; }
        }

    }
}
