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
        private double TotalDagsPris;
        private double TotalAntalDeltagere;
        private double PrisPerPerson;
        private double PrisPerHusstand;
        private double AntalPersonerIHusstand;
        private int AntalVoksneIHusstand;
        private int AntalTeenagerIHusstand;
        private int AntalBarnIHusstand;
        private int AntalBabyIHusstand;

        public string HusNummer;

        //Properties


        //constuctor
        public HusInfo(string HusNummer, int AntalVoksneIHusstand, int AntalTeenagerIHusstand, int AntalBarnIHusstand, int AntalBabyIHusstand)
        {
            this.HusNummer = HusNummer;
            this.AntalVoksneIHusstand = 0;
            this.AntalTeenagerIHusstand = 0;
            this.AntalBarnIHusstand = 0;
            this.AntalBabyIHusstand = 0;
        }
        // beregningers metoder

        public double GetAntalPersonerIHusstand()
        {
            return AntalPersonerIHusstand = AntalBabyIHusstand + AntalBarnIHusstand + AntalTeenagerIHusstand + AntalVoksneIHusstand;
        }
        
        public double GetAntalVoksneIHusstand()
        {
            return  AntalVoksneIHusstand * 1.0;
        }

        public double GetAntalTeenagerIHusstand()
        {
            return AntalTeenagerIHusstand * 0.5;
        }

        public double GetAntalBarnIHusstand()
        {
            return AntalBarnIHusstand * 0.25;
        }

        public double GetAntalBabyIHusstand()
        {
            return AntalBabyIHusstand * 0;
        }

        public double GetPrisPerPerson()
        {
            return TotalDagsPris/TotalAntalDeltagere;
        }

        public double GetPrisPerHusstand()
        {
            return PrisPerPerson* AntalPersonerIHusstand;
        }

        public double GetTotalAntalDeltagere()
        {
            return 0;//lave et foreach loop på listen med antalpersonerihusstand 
        }

    }
}
