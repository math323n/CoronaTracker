using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Corona_Tracker
{
    public class Repository
    {
        protected readonly string url = @"https://corona.lmao.ninja/v2/countries/";
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

        public Corona GetCoronaTrackingForCountry(string countryName)
        {
            List<Corona> countries = GetCoronaTracking();
            
            foreach(Corona country in countries)
            {
                if(country.Country == countryName)
                {
                    return country;
                }
                
            }
            return null;
        }

    }
}