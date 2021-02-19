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
    public class ProfessorController : ControllerBase
    {       
        private readonly IRepository _repo;
        private readonly IMapper _mapper;

        public ProfessorController(IRepository repo,
                                  IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var professores = _repo.GetAllProfessores(true);
            return Ok(_mapper.Map<IEnumerable<ProfessorDto>>(professores));
        }

        // GET api/<ProfessorController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var professor = _repo.GetAllProfessoresById(id);
            if (professor == null) return BadRequest("O professor não foi encontrado");

            var professorDto = _mapper.Map<ProfessorDto>(professor);


            return Ok(professorDto);
        }
        //[HttpGet("{nome}")]
        //public IActionResult Get(string nome)
        //{
        //    var professor = _context.Professores.FirstOrDefault(a => a.Nome == nome);
        //    if (professor == null) return BadRequest("O professor não foi encontrado");

        //    return Ok(professor);
        //}
        //[HttpGet("ByName")]
        //public IActionResult GetByName(string nome)
        //{
        //    var professor = _context.Professores.FirstOrDefault(a => a.Nome.Contains(nome));
        //    if (professor == null) return BadRequest("O professor não foi encontrado");

        //    return Ok(professor);
        //}
        // POST api/<ProfessorController>
        [HttpPost]
        public IActionResult Post(ProfessorRegistrarDto model)
        {
            var professor = _mapper.Map<Professor>(model);
            _repo.Add(professor);
            if (_repo.SaveChanges())
                return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));

            return BadRequest("Professor não cadastrado");
            //_context.Add(professor);
            //_context.SaveChanges();
            //return Ok(professor);
        }

        // PUT api/<ProfessorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, ProfessorRegistrarDto model)
        {
            var professor = _repo.GetAllProfessoresById(id);
            if (professor == null) return BadRequest("professor nao encontrado");

            _mapper.Map(model, professor);
            _repo.Update(professor);
            if (_repo.SaveChanges())
                return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));

            return BadRequest("Professor não atualizado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, ProfessorRegistrarDto model)
        {
            var professor = _repo.GetAllProfessoresById(id);
            if (professor == null) return BadRequest("professor nao encontrado");

            _mapper.Map(model, professor);
            _repo.Update(professor);
            if (_repo.SaveChanges())
                return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));

            return BadRequest("Professor não atualizado");
        }

        // DELETE api/<ProfessorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _repo.GetAllProfessoresById(id);
            if (professor == null) return BadRequest("Professor nao encontrado");
            _repo.Delete(professor);
            if (_repo.SaveChanges())
                return Ok("Professor deletado");

            return BadRequest("Professor não deletado");
        }
    }
}
