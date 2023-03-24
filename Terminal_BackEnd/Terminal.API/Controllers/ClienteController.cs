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

        [HttpPost("Insertar")]
        public IActionResult Create(ClientesViewModel item)
        {
            var listadoMapeado = _mapper.Map<tbClientes>(item);
            var listado = _terminalService.InsertarCliente(listadoMapeado);
            return Ok(listado);
        }

        [HttpGet("Cliente/Find/{id}")]
        public IActionResult Edit(int id)
        {
            var listado = _terminalService.BuscarCliente(id);
            return Ok(listado);
        }

        [HttpPut("Cliente/Update/{id}")]
        public IActionResult Edit(ClientesViewModel clientesViewModel)
        {
            var listado = _mapper.Map<tbClientes>(clientesViewModel);
            var Result = _terminalService.UpdateCliente(listado);
            return Ok(Result);
        }

        [HttpPost("Cliente/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var listado = _terminalService.BorrarCliente(id);
            return Ok();
        }

    }
}
