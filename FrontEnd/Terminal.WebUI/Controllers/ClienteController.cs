using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Terminal.WebUI.Models;
using Terminal.WebUI.Services;

namespace Terminal.WebUI.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IService_API _serviceApi;

        public ClienteController(IService_API serviceApi)
        {
            _serviceApi = serviceApi;
        }

        public async Task<IActionResult> Index()
        {
            List<ClientesModel> listado = await _serviceApi.List();
            return View(listado);
        }
    }

}
