using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonelApi.DTOs;
using static PersonelApi.Data.PersonelContext;
using static PersonelApi.Repository.BusinessRepository;

namespace PersonelApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SehirController : ControllerBase
    {
        RepSehir _repSehir;
        IMapper _mapper;
        public SehirController(RepSehir repSehir, IMapper mapper)
        {
            _repSehir = repSehir;
            _mapper = mapper;
        }
        [HttpGet("GetSehirler")]
        public ICollection<SehirDTO> GetSehirler()
        {
            return _repSehir.Doldur();

        }
        
        [HttpGet("GetSehir /{id}")]  //0
        public async Task<Sehir> GetSehir(int id)
        {
            return await _repSehir.Find(1);
        }

        [HttpPut("UpdateSehir")]  //1

        public async Task<SehirDTO> UpdateSehir(int id, [FromBody] SehirDTO sehirDTO)
        {
            Sehir secSehir = await _repSehir.Find(sehirDTO.id);
            secSehir = _mapper.Map(sehirDTO,secSehir);
            //secSehir.Ad = sehirDTO.ad;
            //secSehir.resim = sehirDTO.resimYol;
            _repSehir.Update(secSehir);
            await _repSehir.Commit();
            return sehirDTO;
        }


        [HttpPost("EntrySehir")]  //2

        public async Task<SehirDTO> EntrySehir(int id, [FromBody] SehirDTO sehirDTO)
        {
            Sehir yeniSehir = new Sehir();
            yeniSehir = _mapper.Map(sehirDTO, yeniSehir);  // bu dakısa

            //bunlar uzun yol(1., 2., 3.)
            //yeniSehir.Ad = sehirDTO.ad;    1.
            //yeniSehir.ResimYol = sehirDTO.resimyol;  2.
            //yeniSehir.Id = sehirDTO.id;     3.
            _repSehir.Entry(yeniSehir);
            await _repSehir.Commit();
            return sehirDTO;
        }

        [HttpPost("DeleteSehir/{id}")]  //3

        public async Task<Sehir> DeleteSehir(int id)
        {
            Sehir silinenSehir = await _repSehir.Find(id); //önce buluyorum,
            _repSehir.Delete(silinenSehir);   // sonra siliyorum
            await _repSehir.Commit();
            return silinenSehir;
        }
    }
}