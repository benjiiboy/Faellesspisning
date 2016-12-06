using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faellesspisning
{
   public class HusInfo
    {

        





        //instance field
        public double Mandag;
        public double Tirsdag;
        public double Onsdag;
        public double Torsdag;
        public double Fredag;
        public double Lørdag;
        public double Søndag;
        

        //PROPS
        public double TotalDagsPris
        {
            get { return TotalUgePris(); }
            set
            {
                ;
            }
        }



        public double TotalAntalDeltagere { get; set; }
        public double PrisPerPerson { get; set; }
        public double PrisPerHusstand { get; set; }

        public double AntalPersonerIHusstand { get; set; }

        public int AntalVoksneIHusstand { get; set; }
        public int AntalTeenagerIHusstand { get; set; }
        public int AntalBarnIHusstand { get; set; }
        public int AntalBabyIHusstand { get; set; }

        public string HusNummer { get; set; }


        //Metode

        public double TotalUgePris()
        {
            return Mandag + Tirsdag + Onsdag + Torsdag + Fredag + Lørdag + Søndag;
        }

        



    }
}
