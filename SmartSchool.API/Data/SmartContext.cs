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
        public DbSet<AlunoCurso> AlunosCursos { get; set; }
        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Professor> Professores { get; set; }        

        protected override void OnModelCreating(ModelBuilder builder)
        {            
            builder.Entity<AlunoDisciplina>()
                .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });

            builder.Entity<AlunoCurso>()
               .HasKey(AD => new { AD.AlunoId, AD.CursoId });

            builder.Entity<Professor>()
                .HasData(new List<Professor>()
                {
                    new Professor(1, 1, "Lauro", "Lucas"),
                    new Professor(2, 2, "Roberto", "jose"),
                    new Professor(3, 3, "Ronaldo", "marcos"),
                    new Professor(4, 4, "Rodrigo", "rafael"),
                    new Professor(5, 5, "Alexandre", "josefino"),
                });
            builder.Entity<Curso>()
                .HasData(new List<Curso>()
                {
                    new Curso(1,  "Tecnologia da Informação"),
                    new Curso(2, "Sistemas de Informação"),
                    new Curso(3, "Ciência da Computação")                   
                });

            builder.Entity<Disciplina>()
                .HasData(new List<Disciplina>()
                {
                    new Disciplina(1, "Matematica", 1, 1),
                    new Disciplina(2, "Matematica", 1, 3),
                    new Disciplina(3, "Física", 2, 3),
                    new Disciplina(4, "Português", 3, 1),
                    new Disciplina(5, "Inglês", 4, 1),
                    new Disciplina(6, "Inglês", 4, 2),
                    new Disciplina(7, "Inglês", 4, 3),
                    new Disciplina(8, "Porgramação", 5, 1),
                    new Disciplina(9, "Porgramação", 5, 2),
                    new Disciplina(10, "Porgramação", 5, 3),
                });

            builder.Entity<Aluno>()
                .HasData(new List<Aluno>()
                {
                    new Aluno(1, 1, "Marta","kent", "65952233", DateTime.Parse("28/05/2005")),
                    new Aluno(2, 2, "Paula","Isabela", "65952233", DateTime.Parse("28/05/2005")),
                    new Aluno(3, 3, "Laura","Antonia", "65952233", DateTime.Parse("28/05/2005")),
                    new Aluno(4, 4, "Luiza","Machado", "65952233", DateTime.Parse("28/05/2005")),
                    new Aluno(5, 5, "Lucas","Alvares", "65952233", DateTime.Parse("28/05/2005")),
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
                    new AlunoDisciplina() {AlunoId= 5, DisciplinaId= 5},

                });
        }
    }
}
