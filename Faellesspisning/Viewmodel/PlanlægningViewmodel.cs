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
        private Model.Dagsplan minplan = Model.Dagsplan.Instance;

        public Model.Dagsplan Minplan { get { return minplan; } }

    }
}

