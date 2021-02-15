using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {        
        private readonly IRepository _repo;
        public AlunoController(IRepository repo) 
        {
            _repo = repo;           
        }
        //public List<Aluno> Alunos = new List<Aluno>()
        //{
        //    new Aluno()
        //    {
        //        Id = 1,
        //        Nome = "Marcos",
        //        Sobrenome = "fernando",
        //        Telefone = "31996554478",
        //    },

        //    new Aluno()
        //    {
        //        Id = 2,
        //        Nome = "Jose",
        //        Sobrenome = "fernando",
        //        Telefone = "31996554478",
        //    },

        //    new Aluno()
        //    {
        //        Id = 3,
        //        Nome = "teste",
        //        Sobrenome = "fernando",
        //        Telefone = "31996554478",
        //    },

        //};



        // GET: api/<AlunoController>

        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllAlunos(true);
            return Ok(result);
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var aluno = _repo.GetAllAlunosById(id);
            if (aluno == null) return BadRequest("O aluno não foi encontrado");

            return Ok(aluno);
        }        
        //[HttpGet("ByName")]
        //public IActionResult GetByName(string nome, string sobrenome)
        //{
        //    var aluno = _context.Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));
        //    if (aluno == null) return BadRequest("O aluno não foi encontrado");

        //    return Ok(aluno);
        //}
        // POST api/<AlunoController>
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _repo.Add(aluno);
            if (_repo.SaveChanges())
                return Ok(aluno);

            return BadRequest("Aluno não cadastrado");           
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            var alu = _repo.GetAllAlunosById(id);
            if (alu == null) return BadRequest("Aluno nao encontrado");
            _repo.Update(aluno);
            if (_repo.SaveChanges())
                return Ok(aluno);

            return BadRequest("Aluno não atualizado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            var alu = _repo.GetAllAlunosById(id);
            if (alu == null) return BadRequest("Aluno nao encontrado");
            _repo.Update(aluno);
            if (_repo.SaveChanges())
                return Ok(aluno);

            return BadRequest("Aluno não atualizado");
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _repo.GetAllAlunosById(id);
            if (aluno == null) return BadRequest("Aluno nao encontrado");
            _repo.Delete(aluno);
            if (_repo.SaveChanges())
                return Ok("Aluno deletado");

            return BadRequest("Aluno não deletado");
        }
    }
}
