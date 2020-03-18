using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Corona_Tracker
{
    [DesignTimeVisible(false)]
    public partial class MainPage: ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            // Create Repository
            Repository repository = new Repository();
            // Create object
            Corona CoronaChosenCountry = repository.GetCoronaTrackingForCountry("Denmark");

            // Assign binding values
            Cases.BindingContext = CoronaChosenCountry;
            TodayCases.BindingContext = CoronaChosenCountry;
            Deaths.BindingContext = CoronaChosenCountry;
            TodayDeaths.BindingContext = CoronaChosenCountry;
            Recovered.BindingContext = CoronaChosenCountry;
            Critical.BindingContext = CoronaChosenCountry;
        }
    }
}