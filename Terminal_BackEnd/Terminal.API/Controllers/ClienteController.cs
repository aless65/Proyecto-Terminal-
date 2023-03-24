using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terminal.API.Models;
using Terminal.BusinessLogic.Services;
using Terminal.Entities.Entities;

namespace Terminal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly TerminalService _terminalService;
        private readonly IMapper _mapper;

        public ClienteController(TerminalService terminalService, IMapper mapper)
        {
            _terminalService = terminalService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult List()
        {
            var listado = _terminalService.ListadoClientes();
            return Ok(listado);
        }

        [HttpPost]
        public IActionResult Create(VW_tbClientes item)
        {
            var listado = _terminalService.InsertarCliente(item);
            return Ok(listado);
        }

    }
}
