using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faellesspisning.Model 
{
    public class Dagsplan
    {

        private static Dagsplan instance = new Dagsplan();

        public static Dagsplan Instance
        {
            get { return instance; }
        }



        //ctor
        private Dagsplan()
        {

        }



    }
}
