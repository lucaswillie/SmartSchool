using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Dtos;
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
        private readonly IMapper _mapper;
        public AlunoController(IRepository repo, IMapper mapper) 
        {
            _repo = repo;
            _mapper = mapper;
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
            var alunos = _repo.GetAllAlunos(true);
            return Ok(_mapper.Map<IEnumerable<AlunoDto>>(alunos));
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _repo.GetAllAlunosById(id);
            if (aluno == null) return BadRequest("O aluno não foi encontrado");

            var alunoDto = _mapper.Map<AlunoDto>(aluno);
            return Ok(alunoDto);
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
        public IActionResult Post(AlunoRegistrarDto model)
        {
            var aluno = _mapper.Map<Aluno>(model);
            _repo.Add(aluno);
            if (_repo.SaveChanges())
                return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(aluno));

            return BadRequest("Aluno não cadastrado");           
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, AlunoRegistrarDto model)
        {
            var aluno = _repo.GetAllAlunosById(id);
            if (aluno == null) return BadRequest("Aluno nao encontrado");

            _mapper.Map(model, aluno);

            _repo.Update(aluno);
            if (_repo.SaveChanges())
                return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(aluno));

            return BadRequest("Aluno não atualizado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, AlunoRegistrarDto model)
        {
            var aluno = _repo.GetAllAlunosById(id);
            if (aluno == null) return BadRequest("Aluno nao encontrado");

            _mapper.Map(model, aluno);
            _repo.Update(aluno);
            if (_repo.SaveChanges())
                return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(aluno));

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
