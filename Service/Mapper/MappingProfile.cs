using AutoMapper;
using Domain.Entities;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Mapper
{
   public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDTO>().ReverseMap();
        }
    }
}
