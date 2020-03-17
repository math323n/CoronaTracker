using System;

namespace Corona_Tracker
{
    public class Corona
    {
        protected string country;
        protected string cases;
        protected int todayCases;
        protected int deaths;
        protected int todayDeaths;
        protected int recovered;
        protected int critical;

        public Corona(string country, string cases, int todayCases, int deaths, int todayDeaths, int recovered, int critical)
        {
            Country = country;
            Cases = cases;
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

        public virtual string Cases
        {
            get
            {
                return cases;
            }
            set
            {
                cases = value;
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