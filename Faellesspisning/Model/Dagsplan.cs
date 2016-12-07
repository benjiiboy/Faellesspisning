using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Faellesspisning.Model 
{
    public class Dagsplan : INotifyPropertyChanged
    {

        private static Dagsplan instance = new Dagsplan();

        public static Dagsplan Instance
        {
            get { return instance; }
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


        private string mandagMenu;

               public string MandagMenu
        {
            get { return mandagMenu; }
            set
            {
                mandagMenu = value;
                OnPropertyChanged("MandagMenu");
            }
        }


        //ctor
        private Dagsplan()
        {
            this.mandagMenu = "Menu";
        }



    }
}
