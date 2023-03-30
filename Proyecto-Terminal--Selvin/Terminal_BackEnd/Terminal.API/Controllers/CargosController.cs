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
    public class CargosController : ControllerBase
    {

        private readonly TerminalService _terminalService;
        private readonly IMapper _mapper;

        public CargosController(TerminalService terminalService, IMapper mapper)
        {
            _terminalService = terminalService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult List()
        {
            var listado = _terminalService.ListadoCargos();
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Create(CargosViewModel item)
        {
            var listadoMapeado = _mapper.Map<tbCargos>(item);
            var listado = _terminalService.InsertarCargo(listadoMapeado);
            return Ok(listado);
        }


        [HttpGet("Cargo/Find/{id}")]
        public IActionResult Edit(int id)
        {
            var listado = _terminalService.BuscarCargos(id);
            return Ok(listado);
        }

        [HttpPut("Cargo/Update/{id}")]
        public IActionResult Edit(CargosViewModel cargosViewModel)
        {
            var listado = _mapper.Map<tbCargos>(cargosViewModel);
            var Result = _terminalService.UpdateCargos(listado);
            return Ok(Result);
        }

        [HttpPost("Cargo/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var listado = _terminalService.BorrarCargo(id);
            return Ok();
        }
    }
}
