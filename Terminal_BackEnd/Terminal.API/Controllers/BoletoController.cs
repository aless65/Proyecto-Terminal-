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
    public class BoletoController : ControllerBase
    {

        private readonly TerminalService _terminalService;
        private readonly IMapper _mapper;

        public BoletoController(TerminalService terminalService, IMapper mapper)
        {
            _terminalService = terminalService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult List()
        {
            var listado = _terminalService.ListadoBoletos();
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(BoletosViewModel item)
        {
            var listadoMapeado = _mapper.Map<tbBoletos>(item);
            var listado = _terminalService.InsertarBoletos(listadoMapeado);
            return Ok(listado);
        }

        [HttpGet("Boleto/Find/{id}")]
        public IActionResult Edit(int id)
        {
            var listado = _terminalService.BuscarBoletos(id);
            return Ok(listado);
        }

        [HttpPut("Boleto/Update/{id}")]
        public IActionResult Edit(BoletosViewModel boletosViewModel)
        {
            var listado = _mapper.Map<tbBoletos>(boletosViewModel);
            var Result = _terminalService.UpdateBoletos(listado);
            return Ok(Result);
        }

        [HttpPost("Boleto/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var listado = _terminalService.BorrarBoletos(id);
            return Ok();
        }


        [HttpGet("LoadTrips")]
        public IActionResult CargarViajes()
        {
            var listado = _terminalService.LoadTrips();
            return Ok(listado);
        }

        [HttpGet("LoadSex")]
        public IActionResult CargarSexo()
        {
            var listado = _terminalService.LoadSex();
            return Ok(listado);
        }
    }
}
