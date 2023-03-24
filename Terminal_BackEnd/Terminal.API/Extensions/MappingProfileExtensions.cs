using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terminal.Entities.Entities;
using AutoMapper;

namespace Terminal.API.Extensions
{
    public class MappingProfileExtensions : Profile
    {
        public MappingProfileExtensions()
        {
            CreateMap<VW_tbClientes, tbClientes>().ReverseMap();
        } 
    }
}
