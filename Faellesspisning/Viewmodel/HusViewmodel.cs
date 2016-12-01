using Faellesspinsning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faellesspisning.Model;


namespace Faellesspisning.Viewmodel
{
    class HusViewmodel : INotifyPropertyChanged
    {
        //props til knapper 
        public HusListe HusListe { get; set; }
        public HusInfo HusInfo { get; set; }



        // public RelayCommand AddHusCommand {get; set; }


        #region vores PropertyChangedEventHandler 
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
