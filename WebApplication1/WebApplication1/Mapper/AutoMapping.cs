using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Mapper
{
    public class AutoMapping:AutoMapper.Profile
    {
        public AutoMapping()
        {
            CreateMap<GoodsDTO, GoodsModel>()
                .ReverseMap();
            CreateMap<OrganizationDTO, OrganizationModel>()
                .ReverseMap();
            CreateMap<CheckDTO, CheckModel>()
                .ReverseMap();
        }
    }
}
