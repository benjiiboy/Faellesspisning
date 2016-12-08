using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faellesspisning.Viewmodel
{
    public class PlanlægningViewmodel
    {
        private Model.DagsplanSingleton minplan = Model.DagsplanSingleton.Instance;

        public Model.DagsplanSingleton Minplan { get { return minplan; } }

    }
}

