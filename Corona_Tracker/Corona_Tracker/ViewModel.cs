using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Corona_Tracker
{
    public class ViewModel
    {
        private Repository repository;

        public ViewModel()
        {
            repository = new Repository();
            Corona CoronaInDenmark = repository.GetCoronaTrackingForCountry("Denmark");
         //   CoronaInDenmark = new ObservableCollection.Single<Corona>(coronaInDenmark);

        }
        //public ObservableCollection<Corona> CoronaInDenmark { get; set; }
    }
}