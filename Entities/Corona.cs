using System;

namespace Webservice
{
    public class Corona
    {
        protected string country;
        protected int todayCases;
        protected int deaths;
        protected int todayDeaths;
        protected int recovered;
        protected int critical;

        public Corona(string country, int todayCases, int deaths, int todayDeaths, int recovered, int critical)
        {
            Country = country;
            TodayCases = todayCases;
            Deaths = deaths;
            TodayDeaths = todayDeaths;
            Recovered = recovered;
            Critical = critical;
        }

        public virtual string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public virtual int TodayCases
        {
            get
            {
                return todayCases;
            }

            set
            {
                todayCases = value;
            }
        }

        public virtual int Deaths
        {
            get
            {
                return deaths;
            }

            set
            {
                deaths = value;
            }
        }

        public virtual int TodayDeaths
        {
            get
            {
                return todayDeaths;
            }

            set
            {
                todayDeaths = value;
            }
        }

        public virtual int Recovered
        {
            get
            {
                return recovered;
            }

            set
            {
                recovered = value;
            }
        }

        public virtual int Critical
        {
            get
            {
                return critical;
            }

            set
            {
                critical = value;
            }
        }
    }
}