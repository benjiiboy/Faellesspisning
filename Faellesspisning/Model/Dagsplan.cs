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
        //singleton
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
        private string tirsdagMenu;
        private string onsdagMenu;
        private string torsdagMenu;
        private string fredagMenu;
        private string lørdagMenu;
        private string søndagMenu;

               public string MandagMenu
        {
            get { return mandagMenu; }
            set
            {
                mandagMenu = value;
                OnPropertyChanged("MandagMenu");
            }
        }

        public string TirsdagMenu
        {
            get { return tirsdagMenu; }
            set
            {
                tirsdagMenu = value;
                OnPropertyChanged("TirsdagMenu");
            }
        }
        public string OnsdagMenu
        {
            get { return onsdagMenu; }
            set
            {
                onsdagMenu = value;
                OnPropertyChanged("OnsdagMenu");
            }
        }
        public string TorsdagMenu
        {
            get { return torsdagMenu; }
            set
            {
                torsdagMenu = value;
                OnPropertyChanged("TorsdagMenu");
            }
        }
        public string FredagMenu
        {
            get { return fredagMenu; }
            set
            {
                fredagMenu = value;
                OnPropertyChanged("FredagMenu");
            }
        }
        public string LørdagMenu
        {
            get { return lørdagMenu; }
            set
            {
                lørdagMenu = value;
                OnPropertyChanged("LørdagMenu");
            }
        }
        public string SøndagMenu
        {
            get { return søndagMenu; }
            set
            {
                søndagMenu = value;
                OnPropertyChanged("SøndagMenu");
            }
        }

        //ctor
        private Dagsplan()
        {
            this.mandagMenu = "Menu";
            this.tirsdagMenu ="Menu";
            this.onsdagMenu = "Menu";
            this.torsdagMenu = "Menu";
            this.fredagMenu = "Menu";
            this.lørdagMenu = "Menu";
            this.søndagMenu = "Menu";


        }



    }
}
