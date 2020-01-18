using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelApi.Data
{
    public class PersonelContext:DbContext
    {
        public PersonelContext(DbContextOptions<PersonelContext> op):base(op)//1
        {

        }
        //5
        DbSet<Personel> personel { get; set; }
        DbSet<Egitim> egitim { get; set; }
        DbSet<Sehir> sehir { get; set; }

        public class Personel  //2
        {
            [Key]
            public int Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int SehirId { get; set; }

            public int EgitimId { get; set; }
            [ForeignKey("SehirId")]//sehir id girecek alttaki key ile işleşecek.Bu şhir id yi tut alttaki id ye bağla.Bu yüzden hemen alttakini tanımladık
            public Sehir Sehir { get; set; }
            [ForeignKey("EgitimId")]//***Foreign key Egitim egitimin üstünde tanımlanmalı.nereye gideceğini bunun sayesinde anlıyoruz******
            public Egitim Egitim { get; set; }
        }
        public class Sehir  //3
        {
            //[DatabaseGenerated(DatabaseGeneratedOption.None)]//identityi biz belirlemek istersek bunu kullanabiliriz.
            [Key]
            public int Id { get; set; }
            public string Ad { get; set; }
            public string ResimYol { get; set; }
            public ICollection<Personel> Plist { get; set; }

        }
        public class Egitim  //4
        {
            [Key]
            public int Id { get; set; }
            public string Ad { get; set; }
            public ICollection<Personel> Elist { get; set; }

        }

    }
}
