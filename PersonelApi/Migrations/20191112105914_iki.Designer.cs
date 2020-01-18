﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonelApi.Data;

namespace PersonelApi.Migrations
{
    [DbContext(typeof(PersonelContext))]
    [Migration("20191112105914_iki")]
    partial class iki
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersonelApi.Data.PersonelContext+Egitim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad");

                    b.HasKey("Id");

                    b.ToTable("egitim");
                });

            modelBuilder.Entity("PersonelApi.Data.PersonelContext+Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad");

                    b.Property<int>("EgitimId");

                    b.Property<int>("SehirId");

                    b.Property<string>("Soyad");

                    b.HasKey("Id");

                    b.HasIndex("EgitimId");

                    b.HasIndex("SehirId");

                    b.ToTable("personel");
                });

            modelBuilder.Entity("PersonelApi.Data.PersonelContext+Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad");

                    b.Property<string>("ResimYol");

                    b.HasKey("Id");

                    b.ToTable("sehir");
                });

            modelBuilder.Entity("PersonelApi.Data.PersonelContext+Personel", b =>
                {
                    b.HasOne("PersonelApi.Data.PersonelContext+Egitim", "Egitim")
                        .WithMany("Elist")
                        .HasForeignKey("EgitimId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PersonelApi.Data.PersonelContext+Sehir", "Sehir")
                        .WithMany("Plist")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
