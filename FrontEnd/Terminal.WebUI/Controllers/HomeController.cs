using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Terminal.WebUI.Models;

namespace Terminal.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private static string _baseurl;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> GraficaViajes()
        {

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + $"api/Boleto/LoadTrips");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var Grafica = JsonConvert.DeserializeObject<List<GraficaViajesViewModel>>(content);

                    return Json(Grafica);
                }
                else
                {
                    return RedirectToAction("Index");

                }
            }

        }

        public async Task<IActionResult> GraficaSexo()
        {

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + $"api/Boleto/LoadSex");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var Grafica = JsonConvert.DeserializeObject<List<GraficaSexoViewModel>>(content);

                    return Json(Grafica);
                }
                else
                {
                    return RedirectToAction("Index");

                }
            }

        }
    }
}
