using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Faellesspisning.Model
{
   public class HusListe : ObservableCollection<HusInfo>
    {
        public HusListe() :base()
        {
            this.Add(new HusInfo());
            //TODO: tilføj set metoder i husinfo
        }

        public string GetJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public void IndsætJson(string JsonText)
        {
            List<HusInfo> nyListe = JsonConvert.DeserializeObject<List<HusInfo>>(JsonText);
            foreach(var i in nyListe)
            {
                this.Add(i);
            }
        }

    }
}