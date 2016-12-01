using Faellesspinsning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Faellesspisning.Viewmodel
{
    class HusViewmodel : INotifyPropertyChanged
    {
        //props til knapper 
        public Model.HusListe HusListe { get; set; }
        public Model. MyProperty { get; set; }

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
