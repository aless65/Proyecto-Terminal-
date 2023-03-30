using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public async Task<IActionResult> VistaPrevia()
        {

            List<PreviaViewModelcs> listado = new List<PreviaViewModelcs>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Boleto/VistaPrevia");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    listado = JsonConvert.DeserializeObject<List<PreviaViewModelcs>>(jsonResponse);
                }
                return View(listado);
            }
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            //Llenar ddl de terminal
            List<TerminalesViewModel> terminales = new List<TerminalesViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Terminal");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    terminales = JsonConvert.DeserializeObject<List<TerminalesViewModel>>(jsonResponse);
                    ViewBag.term_Id = new SelectList(terminales, "term_ID", "term_Nombre"); 
                }
            }
            //Fin Llenar ddl de tarminal


            //Llenar ddl de Compañia
            List<CompañiaViewModel> compania = new List<CompañiaViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Compania");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    compania = JsonConvert.DeserializeObject<List<CompañiaViewModel>>(jsonResponse);
                    ViewBag.comp_Id = new SelectList(compania, "comp_ID", "comp_Nombre");
                }
                
            }
            //Fin llenar ddl de Compañia

            //Llenar ddl de Empelado
            List<EmpleadoViewModel> empleado = new List<EmpleadoViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Empleado");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    empleado = JsonConvert.DeserializeObject<List<EmpleadoViewModel>>(jsonResponse);
                    ViewBag.empl_ID = new SelectList(empleado, "empl_ID", "empl_NombreCompleto");
                }
            }
            //Fin Llenas ddl de empleado

            //Llenar ddl de clientes 
            List<ClientesModel> clientes = new List<ClientesModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Cliente");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    clientes = JsonConvert.DeserializeObject<List<ClientesModel>>(jsonResponse);
                    ViewBag.clie_ID = new SelectList(clientes, "clie_ID", "clie_NombreCompleto");
                }
            }
            //Fin llenar dll de clientes

            //Llenar dll de Horarios
            List<HorariosViewModel> horario = new List<HorariosViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Horario");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    horario = JsonConvert.DeserializeObject<List<HorariosViewModel>>(jsonResponse);
                    ViewBag.hora_ID = new SelectList(horario, "hora_ID", "horario");
                }
         
            }
            //Fin llenar dll de horarios
            return View();
        }
  

        public async Task<IActionResult> Create(BoletosViewModel boletosViewModel)
        {
            if (ModelState.IsValid)
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
            else
            {
                //Llenar ddl de terminal
                List<TerminalesViewModel> terminales = new List<TerminalesViewModel>();

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(_baseurl + "api/Terminal");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        terminales = JsonConvert.DeserializeObject<List<TerminalesViewModel>>(jsonResponse);
                        ViewBag.term_Id = new SelectList(terminales, "term_ID", "term_Nombre");
                    }
                }
                //Fin Llenar ddl de tarminal


                //Llenar ddl de Compañia
                List<CompañiaViewModel> compania = new List<CompañiaViewModel>();

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(_baseurl + "api/Compania");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        compania = JsonConvert.DeserializeObject<List<CompañiaViewModel>>(jsonResponse);
                        ViewBag.comp_Id = new SelectList(compania, "comp_ID", "comp_Nombre");
                    }

                }
                //Fin llenar ddl de Compañia

                //Llenar ddl de Empelado
                List<EmpleadoViewModel> empleado = new List<EmpleadoViewModel>();

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(_baseurl + "api/Empleado");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        empleado = JsonConvert.DeserializeObject<List<EmpleadoViewModel>>(jsonResponse);
                        ViewBag.empl_ID = new SelectList(empleado, "empl_ID", "empl_NombreCompleto");
                    }
                }
                //Fin Llenas ddl de empleado

                //Llenar ddl de clientes 
                List<ClientesModel> clientes = new List<ClientesModel>();

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(_baseurl + "api/Cliente");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        clientes = JsonConvert.DeserializeObject<List<ClientesModel>>(jsonResponse);
                        ViewBag.clie_ID = new SelectList(clientes, "clie_ID", "clie_NombreCompleto");
                    }
                }
                //Fin llenar dll de clientes

                //Llenar dll de Horarios
                List<HorariosViewModel> horario = new List<HorariosViewModel>();

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(_baseurl + "api/Horario");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        horario = JsonConvert.DeserializeObject<List<HorariosViewModel>>(jsonResponse);
                        ViewBag.hora_ID = new SelectList(horario, "hora_ID", "horario");
                    }

                }
                //Fin llenar dll de horarios
                return View(boletosViewModel);
            }
        }


        public async Task<IActionResult> Edit(int id)
        {
            //Llenar ddl de terminal
            List<TerminalesViewModel> terminales = new List<TerminalesViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Terminal");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    terminales = JsonConvert.DeserializeObject<List<TerminalesViewModel>>(jsonResponse);
                    ViewBag.term_Id = new SelectList(terminales, "term_ID", "term_Nombre");
                }
            }
            //Fin Llenar ddl de tarminal


            //Llenar ddl de Compañia
            List<CompañiaViewModel> compania = new List<CompañiaViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Compania");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    compania = JsonConvert.DeserializeObject<List<CompañiaViewModel>>(jsonResponse);
                    ViewBag.comp_Id = new SelectList(compania, "comp_ID", "comp_Nombre");
                }

            }
            //Fin llenar ddl de Compañia

            //Llenar ddl de Empelado
            List<EmpleadoViewModel> empleado = new List<EmpleadoViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Empleado");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    empleado = JsonConvert.DeserializeObject<List<EmpleadoViewModel>>(jsonResponse);
                    ViewBag.empl_ID = new SelectList(empleado, "empl_ID", "empl_NombreCompleto");
                }
            }
            //Fin Llenas ddl de empleado

            //Llenar ddl de clientes 
            List<ClientesModel> clientes = new List<ClientesModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Cliente");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    clientes = JsonConvert.DeserializeObject<List<ClientesModel>>(jsonResponse);
                    ViewBag.clie_ID = new SelectList(clientes, "clie_ID", "clie_NombreCompleto");
                }
            }
            //Fin llenar dll de clientes

            //Llenar dll de Horarios
            List<HorariosViewModel> horario = new List<HorariosViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Horario");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    horario = JsonConvert.DeserializeObject<List<HorariosViewModel>>(jsonResponse);
                    ViewBag.hora_ID = new SelectList(horario, "hora_ID", "horario");
                }

            }
            //Fin llenar dll de horarios
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

        public async Task<IActionResult> GetPrecio(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + $"api/Boleto/Boleto/Find/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var cliente = JsonConvert.DeserializeObject<BoletosViewModel>(content);
                    return Json(cliente);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }


        public async Task<IActionResult> Update(BoletosViewModel boletos)
        {
            if (ModelState.IsValid)
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
            else
            {
                #region ModelState
                //Llenar ddl de terminal
                List<TerminalesViewModel> terminales = new List<TerminalesViewModel>();

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(_baseurl + "api/Terminal");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        terminales = JsonConvert.DeserializeObject<List<TerminalesViewModel>>(jsonResponse);
                        ViewBag.term_Id = new SelectList(terminales, "term_ID", "term_Nombre");
                    }
                }
                //Fin Llenar ddl de tarminal


                //Llenar ddl de Compañia
                List<CompañiaViewModel> compania = new List<CompañiaViewModel>();

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(_baseurl + "api/Compania");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        compania = JsonConvert.DeserializeObject<List<CompañiaViewModel>>(jsonResponse);
                        ViewBag.comp_Id = new SelectList(compania, "comp_ID", "comp_Nombre");
                    }

                }
                //Fin llenar ddl de Compañia

                //Llenar ddl de Empelado
                List<EmpleadoViewModel> empleado = new List<EmpleadoViewModel>();

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(_baseurl + "api/Empleado");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        empleado = JsonConvert.DeserializeObject<List<EmpleadoViewModel>>(jsonResponse);
                        ViewBag.empl_ID = new SelectList(empleado, "empl_ID", "empl_NombreCompleto");
                    }
                }
                //Fin Llenas ddl de empleado

                //Llenar ddl de clientes 
                List<ClientesModel> clientes = new List<ClientesModel>();

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(_baseurl + "api/Cliente");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        clientes = JsonConvert.DeserializeObject<List<ClientesModel>>(jsonResponse);
                        ViewBag.clie_ID = new SelectList(clientes, "clie_ID", "clie_NombreCompleto");
                    }
                }
                //Fin llenar dll de clientes

                //Llenar dll de Horarios
                List<HorariosViewModel> horario = new List<HorariosViewModel>();

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(_baseurl + "api/Horario");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        horario = JsonConvert.DeserializeObject<List<HorariosViewModel>>(jsonResponse);
                        ViewBag.hora_ID = new SelectList(horario, "hora_ID", "horario");
                    }

                }
                //Fin llenar dll de horarios
                #endregion
                return View();
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
