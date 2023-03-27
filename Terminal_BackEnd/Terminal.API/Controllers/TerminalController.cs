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
    public class TerminalController : ControllerBase
    {
        private readonly TerminalService _terminalService;
        private readonly IMapper _mapper;

        public TerminalController(TerminalService terminalService, IMapper mapper)
        {
            _terminalService = terminalService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult List()
        {
            var listado = _terminalService.ListadoTerminales();
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(TerminalesViewModel item)
        {
            var listadoMapeado = _mapper.Map<tbTerminales>(item);
            var listado = _terminalService.InsertarTerminal(listadoMapeado);
            return Ok(listado);
        }

        [HttpGet("Terminal/Find/{id}")]
        public IActionResult Edit(int id)
        {
            var listado = _terminalService.BuscarTerminales(id);
            return Ok(listado);
        }

        [HttpPut("Terminal/Update/{id}")]
        public IActionResult Edit(TerminalesViewModel terminales)
        {
            var listado = _mapper.Map<tbTerminales>(terminales);
            var Result = _terminalService.UpdateTerminales(listado);
            return Ok(Result);
        }


        [HttpGet("Terminal/DeleteTerminal/{id}")]
        public IActionResult DeleteT(int id)
        {
            var listado = _terminalService.BuscarTerminales(id);
            return Ok(listado);
        }


        [HttpPost("Terminal/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var listado = _terminalService.BorrarTerminales(id);
            return Ok();
        }

        [HttpGet("LoadDepartamento")]
        public IActionResult CargarDepartamentos()
        {
            var listado = _terminalService.LoadDepartamento();
            return Ok(listado);
        }

        [HttpGet("Terminal/FindMunicipio/{id}")]
        public IActionResult CargarMunicipios(string id)
        {
            var cargarmunicipios = _terminalService.LoadMunicipio(id);
            return Ok(cargarmunicipios);
        }
    }
}
