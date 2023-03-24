using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaApi.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using PruebaApi.Entities.Entities;

namespace PruebaApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly TermService _TermService;
        private readonly IMapper _mapper;

        public ClientesController(TermService termService,IMapper mapper)
        {
            _TermService = termService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Listado()
        {
            var listado = _TermService.ListadoClientes();
            return Ok(listado);
        }

        [HttpPost]
        public IActionResult Create(tbClientes item)
        {
            var listado = _TermService.InsertarCliente(item);
            return Ok(listado);
        }
    }
}
