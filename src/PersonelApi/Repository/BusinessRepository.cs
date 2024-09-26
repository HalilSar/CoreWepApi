using PersonelApi.Data;
using PersonelApi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PersonelApi.Data.PersonelContext;

namespace PersonelApi.Repository
{
    public class BusinessRepository
    {
        public class RepSehir : BaseRepository<Sehir>
        {
            public RepSehir(PersonelContext db):base (db)
            {

            }
            public ICollection<SehirDTO> Doldur()
            {
                return Set().Select(x => new SehirDTO
                {
                    id = x.Id,
                    ad = x.Ad,
                    resimyol = x.ResimYol
                }).ToList();
            }

        }
        public class RepPersonel : BaseRepository<Personel>
        {
            public RepPersonel(PersonelContext db) : base(db)
            {

            }

        }
        public class RepEgitim : BaseRepository<Egitim>
        {
            public RepEgitim(PersonelContext db) : base(db)
            {

            }

        }

    }
}
