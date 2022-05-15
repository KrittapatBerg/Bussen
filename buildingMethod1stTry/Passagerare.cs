using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildingMethod1stTry
{
    internal class Passagerare
    {
        public string namn;
        public int ålder;
        public string kön;
        public int bagage;
        public string destination;
        public int sittplats;

        public Passagerare(string aNamn, int aÅlder, string aKön, int aBagage, string aDestination, int aSittplats)
        {
            namn = aNamn;
            ålder = aÅlder;
            kön = aKön;
            bagage = aBagage;   
            destination = aDestination;
            sittplats = aSittplats;
        }
        
    }
}
