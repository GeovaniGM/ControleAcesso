﻿// <auto-generated />
using System;
using ControleAcesso.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleAcesso.Migrations
{
    [DbContext(typeof(AcademiaContext))]
    partial class AcademiaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("ControleAcesso.Model.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("CPF");

                    b.Property<int>("Codigo");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Nome");

                    b.Property<int>("Plano");

                    b.Property<string>("RG");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
