using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEB191010.Models;
using WEB191010.Dtos;

namespace WEB191010.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Ugyfel, UgyfelDto>();
            Mapper.CreateMap<UgyfelDto, Ugyfel>();
        }
    }
}