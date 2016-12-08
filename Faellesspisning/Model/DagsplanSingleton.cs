﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Faellesspisning.Model 
{
    public class DagsplanSingleton : INotifyPropertyChanged
    {
        //singleton
        private static DagsplanSingleton instance = new DagsplanSingleton();

        public static DagsplanSingleton Instance
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

        #region Instance field Menu dage
        private string mandagMenu;
        private string tirsdagMenu;
        private string onsdagMenu;
        private string torsdagMenu;
        private string fredagMenu;
        private string lørdagMenu;
        private string søndagMenu;
        #endregion


        #region instance field kok dage
        private string kokMandag;
        private string kokTirsdag;
        private string kokOnsdag;
        private string kokTorsdag;
        private string kokFredag;
        private string kokLørdag;
        private string kokSøndag;
        #endregion

        #region instance field hjælpere dage
        private string hjælpereMandag;
        private string hjælpereTirsdag;
        private string hjælpereOnsdag;
        private string hjælpereTorsdag;
        private string hjælpereFredag;
        private string hjælpereLørdag;
        private string hjælpereSøndag;

        #endregion

        #region Menu

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
#endregion

        #region Kokke
        public string KokMandag
        {
            get { return kokMandag; }
            set
            {
                kokMandag = value;
                OnPropertyChanged("KokMandag");
            }
        }

        public string KokTirsdag
        {
            get { return kokTirsdag; }
            set
            {
                kokTirsdag = value;
                OnPropertyChanged("KokTirsdag");
            }
        }

        public string KokOnsdag
        {
            get { return kokOnsdag; }
            set
            {
                kokOnsdag = value;
                OnPropertyChanged("KokOnsdag");
            }
        }

        public string KokTorsdag
        {
            get { return kokTorsdag; }
            set
            {
                kokTorsdag = value;
                OnPropertyChanged("KokTorsdag");
            }
        }

        public string KokFredag
        {
            get { return kokFredag; }
            set
            {
                kokFredag = value;
                OnPropertyChanged("KokFredag");
            }
        }

        public string KokLørdag
        {
            get { return kokLørdag; }
            set
            {
                kokLørdag = value;
                OnPropertyChanged("KokLørdag");
            }
        }

        public string KokSøndag
        {
            get { return kokSøndag; }
            set
            {
                kokSøndag = value;
                OnPropertyChanged("KokSøndag");
            }
        }

        #endregion

        #region Hjælpere

        public string HjælpereMandag
        {
            get { return hjælpereMandag; }
            set
            {
                hjælpereMandag = value;
                OnPropertyChanged("HjælpereMandag");
            }
        }

        public string HjælpereTirsdag
        {
            get { return hjælpereTirsdag; }
            set
            {
                hjælpereTirsdag = value;
                OnPropertyChanged("HjælpereMTirsdag");
            }
        }

        public string HjælpereOnsdag
        {
            get { return hjælpereOnsdag; }
            set
            {
                hjælpereOnsdag = value;
                OnPropertyChanged("HjælpereOnsdag");
            }
        }

        public string HjælpereTorsdag
        {
            get { return hjælpereTorsdag; }
            set
            {
                hjælpereTorsdag = value;
                OnPropertyChanged("HjælpereTorsdag");
            }
        }

        public string HjælpereFredag
        {
            get { return hjælpereFredag; }
            set
            {
                hjælpereFredag = value;
                OnPropertyChanged("HjælpereFredag");
            }
        }

        public string HjælpereLørdag
        {
            get { return hjælpereLørdag; }
            set
            {
                hjælpereLørdag = value;
                OnPropertyChanged("HjælpereLørdag");
            }
        }

        public string HjælpereSøndag
        {
            get { return hjælpereSøndag; }
            set
            {
                hjælpereSøndag = value;
                OnPropertyChanged("HjælpereSøndag");
            }
        }

        #endregion

        //ctor
        private DagsplanSingleton()
        {
            this.mandagMenu = "";
            this.tirsdagMenu ="";
            this.onsdagMenu = "";
            this.torsdagMenu = "";
            this.fredagMenu = "";
            this.lørdagMenu = "";
            this.søndagMenu = "";

            this.kokMandag = "";
            this.kokTirsdag = "";
            this.kokOnsdag = "";
            this.kokTorsdag = "";
            this.kokFredag = "";
            this.kokLørdag = "";
            this.kokSøndag = "";

            this.hjælpereMandag = "";
            this.hjælpereTirsdag = "";
            this.hjælpereOnsdag = "";
            this.hjælpereTorsdag = "";
            this.hjælpereFredag = "";
            this.hjælpereLørdag = "";
            this.hjælpereSøndag = "";

            DagsplanSingleton NyKokHjælp = new DagsplanSingleton();
        }
        public DagsplanSingleton NyKokHjælp { get; set; }
        public List<DagsplanSingleton> HjælpeKokListe = new List<DagsplanSingleton>();

        public void AddHjælpKok()
        {
   DagsplanSingleton temphusinfo = new DagsplanSingleton();
            temphusinfo.KokMandag = NyKokHjælp.KokMandag;
            temphusinfo.KokTirsdag = NyKokHjælp.KokTirsdag;
            temphusinfo.KokOnsdag = NyKokHjælp.KokOnsdag;
            temphusinfo.KokTorsdag = NyKokHjælp.KokTorsdag;
            temphusinfo.KokFredag = NyKokHjælp.KokFredag;
            temphusinfo.KokLørdag = NyKokHjælp.KokLørdag;
            temphusinfo.KokSøndag = NyKokHjælp.KokSøndag;

            temphusinfo.HjælpereMandag = NyKokHjælp.HjælpereMandag;
            temphusinfo.HjælpereTirsdag = NyKokHjælp.HjælpereTirsdag;
            temphusinfo.HjælpereOnsdag = NyKokHjælp.HjælpereOnsdag;
            temphusinfo.HjælpereTorsdag = NyKokHjælp.HjælpereTorsdag;
            temphusinfo.HjælpereFredag = NyKokHjælp.HjælpereFredag;
            temphusinfo.HjælpereLørdag = NyKokHjælp.HjælpereLørdag;
            temphusinfo.HjælpereSøndag = NyKokHjælp.HjælpereSøndag;



            //HList.Remove(temphusinfo);
        }

        public override string ToString()
        {
            return 

        }

    }
}
