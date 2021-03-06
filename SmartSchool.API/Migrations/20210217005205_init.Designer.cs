﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.API.Data;

namespace SmartSchool.API.Migrations
{
    [DbContext(typeof(SmartContext))]
    [Migration("20210217005205_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("SmartSchool.API.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<int>("Matricula")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(878),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Marta",
                            Sobrenome = "kent",
                            Telefone = "65952233"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(2461),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 2,
                            Nome = "Paula",
                            Sobrenome = "Isabela",
                            Telefone = "65952233"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(2503),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 3,
                            Nome = "Laura",
                            Sobrenome = "Antonia",
                            Telefone = "65952233"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(2509),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 4,
                            Nome = "Luiza",
                            Sobrenome = "Machado",
                            Telefone = "65952233"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(2514),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 5,
                            Nome = "Lucas",
                            Sobrenome = "Alvares",
                            Telefone = "65952233"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Nota")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunosCursos");
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Nota")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(3512)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4050)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 3,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4089)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4091)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4092)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4096)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4097)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 3,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4098)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4100)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4102)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4104)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4105)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 3,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4106)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4108)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 179, DateTimeKind.Local).AddTicks(4109)
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            nome = "Tecnologia da Informação"
                        },
                        new
                        {
                            Id = 2,
                            nome = "Sistemas de Informação"
                        },
                        new
                        {
                            Id = 3,
                            nome = "Ciência da Computação"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PrerequisitoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("PrerequisitoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Matematica",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Matematica",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Física",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 4,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 5,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 6,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 7,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 8,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Porgramação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 9,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Porgramação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 10,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Porgramação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Registro")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 175, DateTimeKind.Local).AddTicks(9175),
                            Nome = "Lauro",
                            Registro = 1,
                            Sobrenome = "Lucas"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 176, DateTimeKind.Local).AddTicks(6504),
                            Nome = "Roberto",
                            Registro = 2,
                            Sobrenome = "jose"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 176, DateTimeKind.Local).AddTicks(6534),
                            Nome = "Ronaldo",
                            Registro = 3,
                            Sobrenome = "marcos"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 176, DateTimeKind.Local).AddTicks(6537),
                            Nome = "Rodrigo",
                            Registro = 4,
                            Sobrenome = "rafael"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 16, 21, 52, 5, 176, DateTimeKind.Local).AddTicks(6538),
                            Nome = "Alexandre",
                            Registro = 5,
                            Sobrenome = "josefino"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoCurso", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Disciplina", "Disciplina")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Disciplina", "Prerequisito")
                        .WithMany()
                        .HasForeignKey("PrerequisitoId");

                    b.HasOne("SmartSchool.API.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
