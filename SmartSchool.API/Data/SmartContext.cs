using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data
{
    public class SmartContext : DbContext
    {
        public SmartContext(DbContextOptions<SmartContext> options) : base(options)
        {

        }
        public DbSet<Aluno> Alunos { get; set; }        
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>()
                .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });

            builder.Entity<Professor>()
                .HasData(new List<Professor>()
                {
                    new Professor(1, "Lucas"),
                    new Professor(2, "jose"),
                    new Professor(3, "marcos"),
                    new Professor(4, "rafael"),
                    new Professor(5, "josefino"),
                });

            builder.Entity<Disciplina>()
                .HasData(new List<Disciplina>()
                {
                    new Disciplina(1, "Matematica", 1),
                    new Disciplina(2, "Fisica", 2),
                    new Disciplina(3, "Portugues", 3),
                    new Disciplina(4, "Ingles", 4),
                    new Disciplina(5, "Porgramação", 5),
                });

            builder.Entity<Aluno>()
                .HasData(new List<Aluno>()
                {
                    new Aluno(1, "Marta","kent", "65952233"),
                    new Aluno(2, "Paula","Isabela", "65952233"),
                    new Aluno(3, "Laura","Antonia", "65952233"),
                    new Aluno(4, "Luiza","Machado", "65952233"),
                    new Aluno(5, "Lucas","Alvares", "65952233"),
                });


            builder.Entity<AlunoDisciplina>()
                .HasData(new List<AlunoDisciplina>()
                {
                    new AlunoDisciplina() {AlunoId= 1, DisciplinaId= 1},
                    new AlunoDisciplina() {AlunoId= 1, DisciplinaId= 2},
                    new AlunoDisciplina() {AlunoId= 1, DisciplinaId= 3},
                    new AlunoDisciplina() {AlunoId= 2, DisciplinaId= 1},
                    new AlunoDisciplina() {AlunoId= 2, DisciplinaId= 4},
                    new AlunoDisciplina() {AlunoId= 3, DisciplinaId= 5},
                    new AlunoDisciplina() {AlunoId= 3, DisciplinaId= 4},
                    new AlunoDisciplina() {AlunoId= 4, DisciplinaId= 3},
                    new AlunoDisciplina() {AlunoId= 4, DisciplinaId= 2},
                    new AlunoDisciplina() {AlunoId= 4, DisciplinaId= 1},
                    new AlunoDisciplina() {AlunoId= 5, DisciplinaId= 1},
                    new AlunoDisciplina() {AlunoId= 5, DisciplinaId= 2},
                    new AlunoDisciplina() {AlunoId= 5, DisciplinaId= 3},
                    new AlunoDisciplina() {AlunoId= 5, DisciplinaId= 4},

                });
        }
    }
}
