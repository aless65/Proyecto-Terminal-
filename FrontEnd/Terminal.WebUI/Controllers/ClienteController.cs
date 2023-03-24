using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Terminal.WebUI.Models;

namespace Terminal.WebUI.Controllers
{
    public class ClienteController : Controller
    {
        private static string _baseurl;

        public ClienteController()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _baseurl = builder.GetSection("ApiSettings:baseUrl").Value;

        }

        public async Task<IActionResult> Index()
        {

            List<ClientesModel> listado = new List<ClientesModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Cliente");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    listado = JsonConvert.DeserializeObject<List<ClientesModel>>(jsonResponse);
                }
                return View(listado);
            }
        }


        public async Task<IActionResult> Create(ClientesModel cliente)
        {
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(_baseurl + "api/Cliente/Insertar", content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
        }

    }

}
