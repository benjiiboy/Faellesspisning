﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Faellesspinsning;
using Windows.Storage;

namespace Faellesspisning.Model
{
   public class DeltagerSingleton :INotifyPropertyChanged
    {
        private static DeltagerSingleton instance = new DeltagerSingleton();

        public static DeltagerSingleton Instance
        {
            get { return instance; }
        }


        private DeltagerSingleton()
        {
            HList = new Model.HusListe();
            Newhus = new Model.HusInfo();
            AddHusCommand = new RelayCommand(AddNewHus);
            SletHusCommand = new RelayCommand(Slethus);
            

            localfolder = ApplicationData.Current.LocalFolder;
        }



        private readonly string filnavn = "HusListe.json";
        public Model.HusListe HList { get; set; }
        public Model.HusInfo Newhus { get; set; }



        public RelayCommand AddHusCommand { get; set; }
        public RelayCommand SletHusCommand { get; set; }
        public RelayCommand RedigerCommand { get; set; }
        public RelayCommand BeregnPrisCommand { get; set; }
        public RelayCommand PlanlægCommand { get; set; }

        StorageFolder localfolder = null;

        // public RelayCommand AddHusCommand {get; set; }
        // test commit

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

        private Model.HusInfo SelectedHus;

        public Model.HusInfo selectedHus
        {
            get { return SelectedHus; }
            set
            {
                this.SelectedHus = value;
                this.OnPropertyChanged(nameof(selectedHus));
            }
        }
        #endregion




        //metode til at lave nyt hus
        public void AddNewHus()
        {
            Model.HusInfo temphusinfo = new Model.HusInfo();
            temphusinfo.AntalBabyIHusstand = Newhus.AntalBabyIHusstand;
            temphusinfo.AntalBarnIHusstand = Newhus.AntalBarnIHusstand;
            temphusinfo.AntalTeenagerIHusstand = Newhus.AntalTeenagerIHusstand;
            temphusinfo.AntalVoksneIHusstand = Newhus.AntalVoksneIHusstand;
            temphusinfo.HusNummer = Newhus.HusNummer;

            HList.Add(temphusinfo);

            //HList.Remove(temphusinfo);
        }

        public void Slethus()
        {
            HList.Remove(SelectedHus);
        }


        public async void GemDataTilDiskAsync()
        {
            string jsonText = this.HList.GetJson();
            StorageFile file = await localfolder.CreateFileAsync(filnavn, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, jsonText);
        }

        public async void HentDataFraDiskAsync()
        {
            this.HList.Clear();

            StorageFile file = await localfolder.GetFileAsync(filnavn);
            string jsonText = await FileIO.ReadTextAsync(file);

            HList.IndsætJson(jsonText);
        }

        public void RydlisteData()
        {
            this.HList.Clear();
        }

        //public int MandagTilmeldte()
        //{
        //    int Antal = 0;
        //    foreach (var i in DeltagerListe)
        //    {
        //        Antal += i.AntalPersonerIHusstand;
        //    }
        //    return Antal;
        //}
    }
}
