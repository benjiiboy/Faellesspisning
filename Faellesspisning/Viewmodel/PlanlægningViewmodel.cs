using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faellesspisning.Viewmodel
{
    class PlanlægningViewmodel : INotifyPropertyChanged
    {

        public string mandagMenu;
        public string MandagMenu
        {
            get {return mandagMenu; }
            set { this.mandagMenu = value; OnPropertyChanged(nameof(MandagMenu)); }
        }

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

