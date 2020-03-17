using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Corona_Tracker
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage: ContentPage
    {

       
        public MainPage()
        {
            InitializeComponent();
            Repository repository = new Repository();
            Corona CoronaChosenCountry = repository.GetCoronaTrackingForCountry("Denmark");

            Cases.BindingContext = CoronaChosenCountry;
            TodayCases.BindingContext = CoronaChosenCountry;
            Deaths.BindingContext = CoronaChosenCountry;
            TodayDeaths.BindingContext = CoronaChosenCountry;
            Recovered.BindingContext = CoronaChosenCountry;
            Critical.BindingContext = CoronaChosenCountry;
        }
    }
}