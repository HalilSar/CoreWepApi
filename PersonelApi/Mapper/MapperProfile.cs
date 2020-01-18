using AutoMapper;
using PersonelApi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PersonelApi.Data.PersonelContext;

namespace PersonelApi.Mapper
{
    public class MapperProfile: Profile //neden kullandık ki?
    {
        public MapperProfile()
        {
           /* CreateMap<Sehir, SehirDTO>().ForMember(des => des.ad, opt => opt.MapFrom(src => src.Id)).ForMember(des => des.resimyol, opt=> opt.MapFrom(src => src.ResimYol)); */ //Bi kerede taşır.

            CreateMap<SehirDTO, Sehir>().ForMember(des => des.Ad, opt => opt.MapFrom(src => src.id)).ForMember(des => des.ResimYol, opt => opt.MapFrom(src => src.resimyol));

        }
    }
}
