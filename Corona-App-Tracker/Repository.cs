using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace Webservice
{
    public class Repository
    {
        protected readonly string url = @"https://corona.lmao.ninja/countries/";
        protected string result;
        protected Task<HttpResponseMessage> httpResponse;

        public List<Corona> GetCoronaTracking()
        {
            using(WebClient client = new WebClient())
            {
                result = client.DownloadString(url);
            }

            List<Corona> coronaTracker = JsonConvert.DeserializeObject<List<Corona>>(result);

            return coronaTracker;
        }

        public List<Corona> GetCoronaTrackingForCountry(string countryName)
        {
            List<Corona> countries = GetCoronaTracking();
            List<Corona> danishCorona = new List<Corona>() { };
            foreach(Corona country in countries)
            {
                if(country.Country == countryName)
                {
                    return danishCorona;
                }
                
            }
            return null;
        }

    }
}