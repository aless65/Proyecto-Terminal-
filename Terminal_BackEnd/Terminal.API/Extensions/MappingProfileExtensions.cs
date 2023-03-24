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
        } 
    }
}
