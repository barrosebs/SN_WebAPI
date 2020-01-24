﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SN.WebAPI.Data;

namespace SN.WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200124011716_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("SN.WebAPI.Model.Atleta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Comissao")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataInscricao")
                        .HasColumnType("TEXT");

                    b.Property<int>("FuncaoAtleta")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Nascimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Atletas");
                });
#pragma warning restore 612, 618
        }
    }
}
