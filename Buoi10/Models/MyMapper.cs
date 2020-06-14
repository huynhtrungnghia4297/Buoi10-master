using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buoi10.Models
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            CreateMap<ProductModel,Product>().ReverseMap();
        }
    }
}
