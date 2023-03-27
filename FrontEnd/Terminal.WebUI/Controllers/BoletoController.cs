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
    public class BoletoController : Controller
    {
        private static string _baseurl;

        public BoletoController()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _baseurl = builder.GetSection("ApiSettings:BaseUrl").Value;

        }

        public async Task<IActionResult> Index()
        {

            List<BoletosViewModel> listado = new List<BoletosViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Boleto");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    listado = JsonConvert.DeserializeObject<List<BoletosViewModel>>(jsonResponse);
                }
                return View(listado);
            }
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        public async Task<IActionResult> Create(BoletosViewModel boletosViewModel)
        {
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(boletosViewModel), Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(_baseurl + "api/Boleto/Insertar", content);

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


        public async Task<IActionResult> Edit(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + $"api/Boleto/Boleto/Find/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var cliente = JsonConvert.DeserializeObject<BoletosViewModel>(content);
                    return View(cliente);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }


        public async Task<IActionResult> Update(BoletosViewModel boletos)
        {
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(boletos), Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync(_baseurl + $"api/Boleto/Boleto/Update/{boletos.bole_ID}", content);

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


        public async Task<IActionResult> Delete(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync(_baseurl + $"api/Boleto/Boleto/Delete/{id}", null);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        
    }
}
