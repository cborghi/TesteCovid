using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteCovid.UI.Models
{
    public class RootViewModel
    {
        public string ID { get; set; }
        public string Message { get; set; }
        public GlobalViewModel Global { get; set; }
        public List<CountryViewModel> Countries { get; set; }
        public DateTime Date { get; set; }
    }
}
