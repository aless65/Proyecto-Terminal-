using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terminal.BusinessLogic.Services;

namespace Terminal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly TerminalService _terminalService;
        private readonly IMapper _mapper;

        public EmpleadoController(TerminalService terminalService, IMapper mapper)
        {
            _terminalService = terminalService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult List()
        {
            var listado = _terminalService.ListadoEmpleado();
            return Ok(listado);
        }
    }
}
