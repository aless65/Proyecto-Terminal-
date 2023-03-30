using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terminal.Entities.Entities;
using AutoMapper;
using Terminal.API.Models;

namespace Terminal.API.Extensions
{
    public class MappingProfileExtensions : Profile
    {
        public MappingProfileExtensions()
        {
            CreateMap<ClientesViewModel, tbClientes>().ReverseMap();
            CreateMap<CargosViewModel, tbCargos>().ReverseMap();
            CreateMap<TerminalesViewModel, tbTerminales>().ReverseMap();
            CreateMap<HorariosViewModel, tbHorarios>().ReverseMap();
            CreateMap<BoletosViewModel, tbBoletos>().ReverseMap();
        } 
    }
}
