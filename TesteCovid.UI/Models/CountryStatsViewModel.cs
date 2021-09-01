using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteCovid.UI.Models
{
    public class CountryStatsViewModel
    {
        public string ID { get; set; }
        public string CountryISO { get; set; }
        public string Country { get; set; }
        public string Continent { get; set; }
        public int Population { get; set; }
        public double PopulationDensity { get; set; }
        public double MedianAge { get; set; }
        public double Aged65Older { get; set; }
        public double Aged70Older { get; set; }
        public int ExtremePoverty { get; set; }
        public double GdpPerCapita { get; set; }
        public int CvdDeathRate { get; set; }
        public double DiabetesPrevalence { get; set; }
        public double HandwashingFacilities { get; set; }
        public double HospitalBedsPerThousand { get; set; }
        public double LifeExpectancy { get; set; }
        public int FemaleSmokers { get; set; }
        public int MaleSmokers { get; set; }
    }
}
