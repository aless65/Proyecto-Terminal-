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
    public class HorarioController : ControllerBase
    {
        private readonly TerminalService _terminalService;
        private readonly IMapper _mapper;

        public HorarioController(TerminalService terminalService, IMapper mapper)
        {
            _terminalService = terminalService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult List()
        {
            var listado = _terminalService.ListadoHorarios();
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(HorariosViewModel item)
        {
            var listadoMapeado = _mapper.Map<tbHorarios>(item);
            var listado = _terminalService.InsertarHorario(listadoMapeado);
            return Ok(listado);
        }

        [HttpGet("Horario/Find/{id}")]
        public IActionResult Edit(int id)
        {
            var listado = _terminalService.BuscarHorarios(id);
            return Ok(listado);
        }

        [HttpPut("Horario/Update/{id}")]
        public IActionResult Edit(HorariosViewModel horariosViewModel)
        {
            var listado = _mapper.Map<tbHorarios>(horariosViewModel);
            var Result = _terminalService.UpdateHorarios(listado);
            return Ok(Result);
        }

        [HttpPost("Horario/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var listado = _terminalService.BorrarHorarios(id);
            return Ok();
        }
    }
}
