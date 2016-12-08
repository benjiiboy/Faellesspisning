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
        private Model.Singleton minplan = Model.Singleton.Instance;

        public Model.Singleton Minplan { get { return minplan; } }

    }
}

