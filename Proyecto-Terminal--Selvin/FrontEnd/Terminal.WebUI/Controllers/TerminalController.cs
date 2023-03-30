using Microsoft.AspNetCore.Http;
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
    public class TerminalController : Controller
    {
        private static string _baseurl;
        public TerminalController()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _baseurl = builder.GetSection("ApiSettings:BaseUrl").Value;

        }

        public async Task<IActionResult> Index()
        {

            List<TerminalesViewModel> listado = new List<TerminalesViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Terminal");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    listado = JsonConvert.DeserializeObject<List<TerminalesViewModel>>(jsonResponse);
                }
                return View(listado);
            }
        }


        [HttpGet]
        public async Task<IActionResult> CreateAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var depa = await httpClient.GetAsync(_baseurl + "api/Terminal/LoadDepartamento");

                if (depa.IsSuccessStatusCode)
                {

                    var content = await depa.Content.ReadAsStringAsync();
                    var departamentos = JsonConvert.DeserializeObject<List<DepartamentoViewModel>>(content);
                    ViewBag.dept_ID = new SelectList(departamentos, "dept_ID", "dept_Descripcion");
                    return View();
                }
                else
                {
                    return View();
                }
            }

        }


        public async Task<IActionResult> Create(TerminalesViewModel terminales)
        {

            if (string.IsNullOrEmpty(terminales.dept_ID) || terminales.dept_ID == "0" || string.IsNullOrEmpty(terminales.muni_ID))
            {

                if (string.IsNullOrEmpty(terminales.dept_ID))
                {

                    ModelState.AddModelError("ValidacionDepartamento", "Campo 'Departamento' requerido");

                }
                else
                {
                    using (var httpClient = new HttpClient())
                    {
                        var LoadMunicipios = await httpClient.GetAsync(_baseurl + $"api/Terminal/Terminal/FindMunicipio/{terminales.dept_ID}");

                        var LoadMunicipio = await LoadMunicipios.Content.ReadAsStringAsync();
                        var Municipio = JsonConvert.DeserializeObject<List<MunicipioViewModel>>(LoadMunicipio);
                        ViewBag.muni_ID = new SelectList(Municipio, "muni_ID", "muni_Descripcion");

                    }
                }

                if (string.IsNullOrEmpty(terminales.muni_ID))
                    ModelState.AddModelError("ValidacionMunicipio", "Campo 'Municipio' requerido");

            }


            if (!ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var LoadDepartamentos = await httpClient.GetAsync(_baseurl + "api/Terminal/LoadDepartamento");

                    if (LoadDepartamentos.IsSuccessStatusCode)
                    {

                        var LoadDepartamento = await LoadDepartamentos.Content.ReadAsStringAsync();
                        var departamentos = JsonConvert.DeserializeObject<List<DepartamentoViewModel>>(LoadDepartamento);
                        ViewBag.dept_ID = new SelectList(departamentos, "dept_ID", "dept_Descripcion");

                        var LoadMunicipios = await httpClient.GetAsync(_baseurl + $"api/Terminal/Terminal/FindMunicipio/{terminales.dept_ID}");

                        var LoadMunicipio = await LoadMunicipios.Content.ReadAsStringAsync();
                        var Municipio = JsonConvert.DeserializeObject<List<MunicipioViewModel>>(LoadMunicipio);
                        ViewBag.muni_ID = new SelectList(Municipio, "muni_ID", "muni_Descripcion");

                    }

                }

                return View();
            }
            else
            {

                using (var httpClient = new HttpClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(terminales), Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(_baseurl + "api/Terminal/Insertar", content);

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

        [HttpGet("/Termianl/Edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + $"api/Terminal/Terminal/Find/{id}");
                var LoadDepartamentos = await httpClient.GetAsync(_baseurl + "api/Terminal/LoadDepartamento");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var cliente = JsonConvert.DeserializeObject<TerminalesViewModel>(content);

                    var LoadDepartamento = await LoadDepartamentos.Content.ReadAsStringAsync();
                    var departamentos = JsonConvert.DeserializeObject<List<DepartamentoViewModel>>(LoadDepartamento);
                    ViewBag.dept_ID = new SelectList(departamentos, "dept_ID", "dept_Descripcion", cliente.dept_ID);


                    var LoadMunicipios = await httpClient.GetAsync(_baseurl + $"api/Terminal/Terminal/FindMunicipio/{cliente.dept_ID}");

                    var LoadMunicipio = await LoadMunicipios.Content.ReadAsStringAsync();
                    var Municipio = JsonConvert.DeserializeObject<List<MunicipioViewModel>>(LoadMunicipio);
                    ViewBag.muni_ID = new SelectList(Municipio, "muni_ID", "muni_Descripcion", cliente.muni_ID);

                    return View(cliente);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }

        }

        [HttpPost("/Termianl/Edit/{id}")]
        public async Task<IActionResult> Edit(TerminalesViewModel terminales)
        {

            if (string.IsNullOrEmpty(terminales.dept_ID) || string.IsNullOrEmpty(terminales.muni_ID))
            {

                if (string.IsNullOrEmpty(terminales.dept_ID))
                {

                    ModelState.AddModelError("ValidacionDepartamento", "Campo 'Departamento' requerido");

                }
                else
                {
                    using (var httpClient = new HttpClient())
                    {
                        var LoadMunicipios = await httpClient.GetAsync(_baseurl + $"api/Terminal/Terminal/FindMunicipio/{terminales.dept_ID}");

                        var LoadMunicipio = await LoadMunicipios.Content.ReadAsStringAsync();
                        var Municipio = JsonConvert.DeserializeObject<List<MunicipioViewModel>>(LoadMunicipio);
                        ViewBag.muni_ID = new SelectList(Municipio, "muni_ID", "muni_Descripcion");

                    }
                }

                if (string.IsNullOrEmpty(terminales.muni_ID))
                    ModelState.AddModelError("ValidacionMunicipio", "Campo 'Municipio' requerido");

            }

            if (!ModelState.IsValid)
            {

                using (var httpClient = new HttpClient())
                {
                    var LoadDepartamentos = await httpClient.GetAsync(_baseurl + "api/Terminal/LoadDepartamento");

                    if (LoadDepartamentos.IsSuccessStatusCode)
                    {

                        var LoadDepartamento = await LoadDepartamentos.Content.ReadAsStringAsync();
                        var departamentos = JsonConvert.DeserializeObject<List<DepartamentoViewModel>>(LoadDepartamento);
                        ViewBag.dept_ID = new SelectList(departamentos, "dept_ID", "dept_Descripcion");


                        

                    }

                }

                return View();
                //return RedirectToAction("Edit", new { id = terminales.term_ID });
            }
            else
            {

                using (var httpClient = new HttpClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(terminales), Encoding.UTF8, "application/json");
                    var response = await httpClient.PutAsync(_baseurl + $"api/Terminal/Terminal/Update/{terminales.term_ID}", content);

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

        [HttpGet("/Termianl/Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync(_baseurl + $"api/Terminal/Terminal/DeleteTerminal/{id}", null);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var cliente = JsonConvert.DeserializeObject<TerminalesViewModel>(content);
                    return PartialView("_TerminalView", cliente);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost("Terminal/Delete")]
        public async Task<IActionResult> DeleteConfirm(int term_ID)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync(_baseurl + $"api/Terminal/Terminal/Delete/{term_ID}", null);

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

        public async Task<IActionResult> CargarMunicipios(string id)
        {           
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + $"api/Terminal/Terminal/FindMunicipio/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var Municipio = JsonConvert.DeserializeObject<List<MunicipioViewModel>>(content);
                    //ViewBag.muni_ID = new SelectList(Municipio, "muni_ID", "muni_Descripcion");
                    //return View(cliente);
                    return Json(Municipio);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpGet("/Reporte/Departamento")]
        public async Task<IActionResult> Departamento()
        {
            using (var httpClient = new HttpClient())
            {
                var depa = await httpClient.GetAsync(_baseurl + "api/Terminal/LoadDepartamento");

                if (depa.IsSuccessStatusCode)
                {

                    var content = await depa.Content.ReadAsStringAsync();
                    var departamentos = JsonConvert.DeserializeObject<List<DepartamentoViewModel>>(content);
                     return View(departamentos);
                }
                else
                {
                    return View();
                }
            }

        }

    }
}
