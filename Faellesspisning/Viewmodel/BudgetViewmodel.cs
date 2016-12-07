using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faellesspisning.Viewmodel
{
    class BudgetViewmodel : INotifyPropertyChanged
    {
        //prop

        public string BetalingsTextBlock
        {
            get { return DuskalBetalePerHusstand(); }
            set {  ; }
        }


        public string DuskalBetalePerHusstand()
        {
            return $"du skal betale Gratis" ;
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
