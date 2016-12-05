using Faellesspinsning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;


namespace Faellesspisning.Viewmodel
{
    class HusViewmodel : INotifyPropertyChanged
    {
        //props til knapper 
        public Model.HusListe HList { get; set; }
        public HusInfo Newhus { get; set; }

        public RelayCommand AddHusCommand { get; set; }
        public RelayCommand SletHusCommand { get; set; }
        public RelayCommand RedigerCommand { get; set; }
        public RelayCommand BeregnPrisCommand { get; set; }
        public RelayCommand PlanlægCommand { get; set; }



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

        #region Select hus prop & instance field + comment
        //WriteLine(nameof(person.Address.ZipCode)); // prints "ZipCode”
        // nameof kan altså gå ind på vores Plist fx og finde navn.
        //bliver brugt her med SletElev metode

        public HusInfo SelectedHus;

        public HusInfo selectedHus
        {
            get { return SelectedHus; }
            set
            {
                SelectedHus = value;
                OnPropertyChanged(nameof(selectedHus));
            }
        }
        #endregion

        //metode til at lave nyt hus
        public void AddNewHus()
        {
            HusInfo temphusinfo = new HusInfo();
            //TODO: der skal sættes props ind
            //ie TempKlasseinfo.FirstName = NewElev.FirstName;



            HList.Remove(temphusinfo);
        }

        public void Slethus()
        {
            HList.Remove(SelectedHus);
        }


        public HusViewmodel()
        {
            HList = new Model.HusListe();
            AddHusCommand = new RelayCommand(AddNewHus);
            SletHusCommand = new RelayCommand(Slethus);

        }
    }
}
