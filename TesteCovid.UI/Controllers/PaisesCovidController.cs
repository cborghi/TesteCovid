using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TesteCovid.UI.Models;

namespace TesteCovid.UI.Controllers
{
    public class PaisesCovidController : Controller
    {
        public async Task<IActionResult> Index()
        {
            RootViewModel dadosCovid = new RootViewModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.covid19api.com/summary"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    dadosCovid = JsonConvert.DeserializeObject<RootViewModel>(apiResponse);
                }
            }
            List<CountryViewModel> paisesCovid = dadosCovid.Countries.OrderByDescending(i => i.ActiveCases).Take(10).ToList();

            var cont = 1;
            foreach (var item in paisesCovid)
            {
                item.Position = "º" + cont;
                cont++;
            }
            
            return View(paisesCovid);
        }
    }
}
