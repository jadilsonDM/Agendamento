﻿// <auto-generated />
using System;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infraestructure.Persistence.Migrations
{
    [DbContext(typeof(AgendamentoDbContext))]
    partial class AgendamentoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entity.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDaConsulta")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ExameId")
                        .HasColumnType("int");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int?>("TipoDeExameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExameId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("TipoDeExameId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("Core.Entity.Exame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdTipoExame")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoExame")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Observacao")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("TipoDeExameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoDeExameId");

                    b.ToTable("Exames");
                });

            modelBuilder.Entity("Core.Entity.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNscimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("Core.Entity.TipoDeExame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NomeDoTipo")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TipoDeExames");
                });

            modelBuilder.Entity("Core.Entity.Consulta", b =>
                {
                    b.HasOne("Core.Entity.Exame", "Exame")
                        .WithMany()
                        .HasForeignKey("ExameId");

                    b.HasOne("Core.Entity.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId");

                    b.HasOne("Core.Entity.TipoDeExame", "TipoDeExame")
                        .WithMany()
                        .HasForeignKey("TipoDeExameId");

                    b.Navigation("Exame");

                    b.Navigation("Paciente");

                    b.Navigation("TipoDeExame");
                });

            modelBuilder.Entity("Core.Entity.Exame", b =>
                {
                    b.HasOne("Core.Entity.TipoDeExame", "TipoDeExame")
                        .WithMany("Exames")
                        .HasForeignKey("TipoDeExameId");

                    b.Navigation("TipoDeExame");
                });

            modelBuilder.Entity("Core.Entity.TipoDeExame", b =>
                {
                    b.Navigation("Exames");
                });
#pragma warning restore 612, 618
        }
    }
}